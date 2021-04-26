using MySql.Data.MySqlClient;
using System;
using System.Windows;
using System.Data;
using System.Windows.Media.Animation;
using System.Windows.Controls;
using System.Threading;
using BLL;
using System.Windows.Threading;
using static UIWPF.MainWindow;
using System.Windows.Input;

namespace UIWPF.Resources.Pages
{
    /// <summary>
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class Login : Window
    {
        public static Model.LoginForm.UserInfo globalUser { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗口移动事件
        /// </summary>
        private void windowMouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            LoginProgress.IsEnabled = false;
            loginBtn.IsEnabled = false;
            user.IsEnabled = false;
            psw.IsEnabled = false;
            accRemBox.IsEnabled = false;
            Storyboard storyboard = LoginProgress.Resources["inProgressBoard"] as Storyboard;


            DependencyProperty[] propertyChain = new DependencyProperty[]
             {
                Label.OpacityProperty
             };
            DoubleAnimation txtAnimation = new DoubleAnimation();
            Storyboard storyboard1 = new Storyboard();
            txtAnimation.From = 0;
            txtAnimation.To = 1;
            txtAnimation.Duration = new Duration(TimeSpan.FromSeconds(1));
            storyboard1.Children.Add(txtAnimation);
            storyboard1.AutoReverse = true;
            storyboard1.RepeatBehavior = RepeatBehavior.Forever;
            Storyboard.SetTarget(txtAnimation, LoginInfoTxt);
            Storyboard.SetTargetProperty(txtAnimation,new PropertyPath("(0)",propertyChain));
            storyboard.Begin();
            storyboard1.Begin();
            AutoResetEvent auto = new AutoResetEvent(false);
            string UserId = user.Text.Trim().ToString();
            string Password = psw.Password;

            Thread loginThread = new Thread(() =>
                {
                    try
                    {
                        //DispatcherTimer timer = new DispatcherTimer();
                        //timer.Interval = new TimeSpan(10000000);
                        //timer.Tick += Timer_Tick;
                        //timer.Start();
                        BLL.LoginManager loginManager = new BLL.LoginManager();
                        auto.WaitOne(2000);
                        Model.LoginForm.UserInfo userQuest = loginManager.UserLogin(UserId, Password);
                        
                        if(userQuest != null)
                        {
                            globalUser = userQuest;
                            this.Dispatcher.Invoke(
                            new Action(() =>
                            {
                                storyboard1.Stop();
                                LoginInfoTxt.Opacity = 1;
                                LoginInfoTxt.Content = "欢迎，";
                                LoginInfoTxt.Content += userQuest.UserId;
                            }));
                        }
                        auto.WaitOne(2000);
                        
                        this.Dispatcher.Invoke(
                            new Action(() =>
                            {
                                MainWindow mainWindow = new MainWindow();
                                mainWindow.Show();
                                this.Close();
                            }));
                    }
                    catch(WrongInfoException e)
                    {
                        MessageBox.Show("ERR_LOGIN:0001\n用户名或密码不正确，请重新输入。");
                        this.Dispatcher.Invoke(
                            new Action(() =>
                            {
                                LoginProgress.IsEnabled = true;
                                loginBtn.IsEnabled = true;
                                user.IsEnabled = true;
                                psw.IsEnabled = true;
                                accRemBox.IsEnabled = true;
                                storyboard.Stop();
                                storyboard1.Stop();
                                psw.Password = null;
                            }));
                    }
                    //catch (TimeoutException)
                    //{
                    //    MessageBox.Show("ERR_LOGIN_TIMEOUT:0002");
                    //}
                });
                loginThread.IsBackground = true;
                loginThread.Start();
            
                
        }

        //private void Timer_Tick(object sender, EventArgs e)
        //{

        //    throw new TimeoutException();
        //}



        private void enter_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void regist_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void window_Activated(object sender, EventArgs e)
        {
            Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            string date = $"{DateTime.Now.ToString("yyMMdd")}";
            string displayableVersion = $"{version}.{date}Alpha";
            VersionStatement.Content = displayableVersion;
        }
    }


}
