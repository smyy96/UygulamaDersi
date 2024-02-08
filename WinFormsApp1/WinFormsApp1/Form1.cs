namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> data = new();
            data.Add("1");
            data.Add("1");
            data.Add("1");
            data.Add("1");
            data.Add("1");


            data.ForEach(x => Console.WriteLine(x)); 


        }
    }
}



/*
 
 
public void Foreach(data,method())
 {
    
    foreach(var item in data)
{
method(item)

}
 
 
 */
