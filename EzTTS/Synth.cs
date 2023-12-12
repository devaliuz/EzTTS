using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Globalization;
using NAudio.Lame;
using NAudio.Wave;
using System.Text.RegularExpressions;

namespace EzTTS
{
    internal class Synth
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        public string lang = "en-US";

        public void speak(string text, int speed, string voice)
        {

            synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 0, CultureInfo.GetCultureInfo(lang));
            synth.SelectVoice(voice);
            synth.Rate = speed;
            synth.Speak(text);
        }

        public void save(string text, int speed, string voice)
        {

            if (!Directory.Exists(@"C:\Users\public\SpaceTTSaudio"))
            {
                Directory.CreateDirectory(@"C:\Users\public\SpaceTTSaudio");
            }

            using (SpeechSynthesizer reader = new SpeechSynthesizer())
            {
                reader.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 0, CultureInfo.GetCultureInfo(lang));
                reader.SelectVoice(voice);
                reader.Rate = speed;
                MemoryStream ms = new MemoryStream();
                reader.SetOutputToWaveStream(ms);
                reader.Speak(text);
                text = Regex.Replace(text, @"[^a-zA-Z0-9\-]", "");
                text = text.Truncate();

                ConvertWavStreamToMp3File(ref ms, @"C:\Users\public\SpaceTTSaudio/" + text.ToString() + ".mp3");
            }
        }
        public static void ConvertWavStreamToMp3File(ref MemoryStream ms, string savetofilename)
        {
            ms.Seek(0, SeekOrigin.Begin);

            using (var retMs = new MemoryStream())
            using (var rdr = new WaveFileReader(ms))
            using (var wtr = new LameMP3FileWriter(savetofilename, rdr.WaveFormat, LAMEPreset.VBR_90))
            {
                rdr.CopyTo(wtr);
            }
            ms.Close();
        }
    }
}
