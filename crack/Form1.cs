using Crack;

namespace crack
{
    public partial class crack : Form
    {
        public crack()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // import image
            OpenFileDialog ofd = new OpenFileDialog();
            var result= ofd.ShowDialog();
            if (result == DialogResult.OK) {
                // set image to picturebox
                pictureBox1.Image=Image.FromFile(ofd.FileName);
                // send image to model
                var imagebytes = File.ReadAllBytes(ofd.FileName);
                MLModel1.ModelInput sampledata = new MLModel1.ModelInput();
                {
                    imagesource = imagebytes,
                }
                // load sample data

                var result = await Task.Run(()=> MLModel1.Predict(sampledata);

                // get result
                Labelresult.text = resul1.predictedlabel1
            }
        }
}
