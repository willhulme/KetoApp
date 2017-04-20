using SQLite;
using KetoApp.Models;
using Xamarin.Forms;

namespace KetoApp.SQLite
{
    public class SQLiteAboutPage
    {
        private readonly SQLiteConnection _sqLiteConnection;

        public SQLiteAboutPage()
        {

            _sqLiteConnection = DependencyService.Get<ISQLite>().GetConnection();

            _sqLiteConnection.CreateTable<AboutModel>();

            // ADD
            _sqLiteConnection.Insert(new AboutModel
            {

                //   = "Tutorial about SQLite",
                //Done = false,
            });

            // UPDATE
            _sqLiteConnection.Update(new AboutModel
            {
                //ID = 1,
                //Text = "Creating a tutorial about SQLite",
                //Done = true,
            });
        }


        public ContentPage GetAboutPage()
        {



            var switcher = new Switch();

            var addButton = new Button
            {
                Text = "Add TodoItem"
            };
            addButton.Clicked += (s, e) =>
            {
                _sqLiteConnection.Insert(new AboutModel
                {
                    //Text = entry.Text,
                    //Done = switcher.IsToggled,
                });
            };

            var listView = new ListView
            {
                ItemsSource = _sqLiteConnection.Table<AboutModel>()
            };

            var refreshButton = new Button
            {
                Text = "Refresh TodoItems"
            };
            refreshButton.Clicked += (s, e) =>
            {
                listView.ItemsSource = _sqLiteConnection.Table<AboutModel>();
            };

            var contentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "SQLite Sample",
                            FontSize = 50
                        },
                        //new StackLayout
                        //{
                        //    Orientation = StackOrientation.Horizontal,
                        //    Children =
                        //    {
                        //        entry,
                        //        switcher,
                        //    }
                        //},
                        addButton,
                        refreshButton,
                        listView,
                    }
                }
            };
            return contentPage;
        }
    }
}

