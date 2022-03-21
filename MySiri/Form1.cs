using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Speech.AudioFormat;
using System.Threading.Tasks;

namespace MySiri
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer voice;

        SpeechRecognitionEngine speechRecognition;
        //SpeechRecognitionEngine rec = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
        //public string speech= "Hey";

        public Form1()
        {
            InitializeComponent();

            //Choices cmd = new Choices();
            //cmd.Add(new string[]{"Hi"});
            //GrammarBuilder build = new GrammarBuilder();
            //build.Append(cmd);
            //Grammar gm = new Grammar(build);

            //rec.LoadGrammarAsync(gm);
            //rec.SetInputToDefaultAudioDevice();
            //rec.SpeechRecognized += rec_voice;

        }

        private void rec_voice(object sender, SpeechRecognizedEventArgs e)
        {
            //speech = "Hi...";

            //switch(e.Result.Text)
            //{
            //    case "Hey":textBox1.Text += "Hey";
            //        break;

            //}
            textBox1.Text = e.Result.Text;
            Console.WriteLine(textBox1.Text);
            voice.SelectVoiceByHints(VoiceGender.Female);
            voice.SpeakAsync(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            voice = new SpeechSynthesizer();

            //speechRecognition = new SpeechRecognitionEngine();
            //speechRecognition.SetInputToDefaultAudioDevice();
            //speechRecognition.LoadGrammar(new DictationGrammar());
            //speechRecognition.RecognizeAsync(RecognizeMode.Multiple);
            //speechRecognition.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(rec_voice);



            //rec.SetInputToDefaultAudioDevice();
            //rec.LoadGrammar(new DictationGrammar());
            //rec.RecognizeAsync(RecognizeMode.Multiple);
            //rec.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(rec_voice);

            //while(true)
            //{
            //    textBox1.Text = "Hi .. This is Siri";
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Text = e.ToString();
            //rec.RecognizeAsync(RecognizeMode.Multiple);

            voice.SelectVoiceByHints(VoiceGender.Female);
            voice.SpeakAsync(textBox1.Text);
            Console.WriteLine(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            speechRecognition = new SpeechRecognitionEngine();
            //speechRecognition.Recognize();
            speechRecognition.SetInputToDefaultAudioDevice();
            speechRecognition.LoadGrammar(new DictationGrammar());
            speechRecognition.RecognizeAsync(RecognizeMode.Multiple);
            speechRecognition.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(rec_voice);
            //speechRecognition.Dispose();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            speechRecognition.Dispose();
            //speechRecognition.RecognizeAsyncCancel();
        }
    }
}
