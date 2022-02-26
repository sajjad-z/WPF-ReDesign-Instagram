using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Instagram.UserControls
{
    public partial class Post : UserControl
    {
        public Post()
        {
            InitializeComponent();
        }


        public ImageSource PostSource
        {
            get { return (ImageSource)GetValue(PostSourceProperty); }
            set { SetValue(PostSourceProperty, value); }
        }

        public static readonly DependencyProperty PostSourceProperty = DependencyProperty.Register("PostSource", typeof(ImageSource), typeof(Post));


        public ImageSource ProfileSource
        {
            get { return (ImageSource)GetValue(ProfileSourceProperty); }
            set { SetValue(ProfileSourceProperty, value); }
        }

        public static readonly DependencyProperty ProfileSourceProperty = DependencyProperty.Register("ProfileSource", typeof(ImageSource), typeof(Post));


        public string ProfileName
        {
            get { return (string)GetValue(ProfileNameProperty); }
            set { SetValue(ProfileNameProperty, value); }
        }

        public static readonly DependencyProperty ProfileNameProperty = DependencyProperty.Register("ProfileName", typeof(string), typeof(Post));


        public string Likes
        {
            get { return (string)GetValue(LikesProperty); }
            set { SetValue(LikesProperty, value); }
        }

        public static readonly DependencyProperty LikesProperty = DependencyProperty.Register("Likes", typeof(string), typeof(Post));


        public string Comments
        {
            get { return (string)GetValue(CommentsProperty); }
            set { SetValue(CommentsProperty, value); }
        }

        public static readonly DependencyProperty CommentsProperty = DependencyProperty.Register("Comments", typeof(string), typeof(Post));

    }
}