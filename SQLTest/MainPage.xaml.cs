namespace SQLTest
{
    public partial class MainPage : ContentPage
    {
           

        public MainPage()
        {
            InitializeComponent();
            Stu_List_View.ItemsSource = App.DBTrans.getAllStudents();
        }


        private void Button_Add_Clicked(object sender, EventArgs e)
        {
            App.DBTrans.Add(new Models.StudentClass
            {
                Name = Stu_Name.Text,
                Department = Stu_Dept.Text,
            });
            Stu_List_View.ItemsSource = App.DBTrans.getAllStudents();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender; ;
            App.DBTrans.Delete((int)button.BindingContext);
            Stu_List_View.ItemsSource=App.DBTrans.getAllStudents();
        }


        private void button_Show_Clicked_1(object sender, EventArgs e)
        {

        }
    }

}
