﻿using DDrop.BE.Models;
using DDrop.Utility.Cryptography;
using DDrop.Utility.ImageOperations;
using System;
using System.Data.Entity;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using DDrop.BL.Series;
using DDrop.DAL;
using DDrop.Utility.Mappers;
using ToastNotifications;
using ToastNotifications.Messages;

namespace DDrop
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public static readonly DependencyProperty UserLoginProperty = DependencyProperty.Register("UserLogin", typeof(User), typeof(Login));
        private IDDropRepository _dDropRepository;
        private readonly Notifier _notifier;
        public bool LoginSucceeded;
        public User UserLogin
        {
            get { return (User)GetValue(UserLoginProperty); }
            set
            {
                SetValue(UserLoginProperty, value);
            }
        }

        public Login(IDDropRepository dDropRepository, Notifier notifier)
        {
            _dDropRepository = dDropRepository;
            _notifier = notifier;
            InitializeComponent();
            DataContext = this;
        }

        private async void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            ErrorMessage.Text = "";
            if (TextBoxEmail.Text.Length == 0)
            {
                ErrorMessage.Text = "Введите электронную почту.";
                TextBoxEmail.Focus();
            }
            else if (!Regex.IsMatch(TextBoxEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                ErrorMessage.Text = "Электронная почта имеет не верный формат.";
                TextBoxEmail.Select(0, TextBoxEmail.Text.Length);
                TextBoxEmail.Focus();
            }
            else
            {
                var email = TextBoxEmail.Text;
                var password = LoginPasswordBox.Password;

                try
                {
                    var user = await _dDropRepository.GetUserByLogin(email);

                    if (user != null && PasswordOperations.PasswordsMatch(password, user.Password))
                    {

                        UserLogin = DDropDbEntitiesMapper.DbUserToUser(user);
                        UserLogin.UserSeries = DDropDbEntitiesMapper.DbSeriesToSeries(user.UserSeries, UserLogin);

                        LoginSucceeded = true;
                        _notifier.ShowSuccess($"Пользователь {user.Email} авторизован.");
                        Close();
                    }
                    else
                    {
                        ErrorMessage.Text = "Неверный логин или пароль.";
                        LoginSucceeded = false;
                    }
                }
                catch (Exception exception)
                {
                    _notifier.ShowError("Не удалось установить соединение. Проверьте интернет подключение.");
                }
            }
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Collapsed;
            Registration registrationWindow = new Registration(_dDropRepository, _notifier)
            {
                Owner = this
            };
            registrationWindow.ShowDialog();
            Visibility = Visibility.Visible;

            if (registrationWindow.RegistrationSucceeded)
            {
                UserLogin = registrationWindow.UserLogin;
                LoginSucceeded = true;
                Close();
            }
            else
            {
                LoginSucceeded = false;
                ShowDialog();
            }
        }

        private void TextBoxLogin_OnTextChanged(object sender, TextCompositionEventArgs textCompositionEventArgs)
        {
            ErrorMessage.Text = "";
        }

        private void ToggleButton_OnChecked(object sender, RoutedEventArgs e)
        {
            LoginPasswordBox.Visibility = Visibility.Hidden;
            PasswordUnmask.Visibility = Visibility.Visible;
            PasswordUnmask.Text = LoginPasswordBox.Password;
        }

        private void ToggleButton_OnUnchecked(object sender, RoutedEventArgs e)
        {
            LoginPasswordBox.Visibility = Visibility.Visible;
            PasswordUnmask.Visibility = Visibility.Hidden;
            LoginPasswordBox.Password = PasswordUnmask.Text;
        }

        private void LoginOfflineButton_Click(object sender, RoutedEventArgs e)
        {
            UserLogin = new User()
            {
                Email = "anonymousUser@anonymousUser.com",
                UserPhoto = ImageInterpreter.ImageToByteArray(Properties.Resources.cool_profile_picture_300x219_vectorized__1_),
                FirstName = "Неизвестно",
                LastName = "Неизвестно",
                IsLoggedIn = false,
                Password = PasswordOperations.HashPassword("1q2w3e4r5t6y"),
                UserId = Guid.NewGuid()
            };
            LoginSucceeded = true;

            Close();
        }
    }
}
