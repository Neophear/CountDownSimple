using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace CountDownSimple
{
    public class Settings
    {
        public DateTime TargetDate = DateTime.Now;
        public bool TopMost = true;
        public Size WindowSize = new Size();
        public Point Location = new Point();
        public bool ShowBottomText = true;
        public bool AlwaysOnTop = true;

        [XmlIgnore]
        public Color BackgroundColor = Color.FromArgb(0, 0, 64);
        [XmlIgnore]
        public Color ForeColor = Color.White;
        public string TextFormat = "[D] [DT], [H] [HT], [M] [MT], [S] [ST]";

        [XmlIgnore]
        private Font _textFont = new Font("Monotype Corsiva", 22f, FontStyle.Italic);

        [XmlIgnore]
        public Font TextFont
        {
            get { return _textFont; }
            set { _textFont = value; }
        }

        [Browsable(false)]
        public string sBackgroundColorHTML;
        [Browsable(false)]
        public string sForeColorHTML;
        [Browsable(false)]
        public string FontSerialize
        {
            get { return TypeDescriptor.GetConverter(typeof(Font)).ConvertToInvariantString(_textFont); }
            set { _textFont = TypeDescriptor.GetConverter(typeof(Font)).ConvertFromInvariantString(value) as Font; }
        }

        #region Serialize
        private static string _appConfPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\CountDownSimple\\";
        public static void Serialize(Settings settings)
        {
            Directory.CreateDirectory(_appConfPath);

            settings.sBackgroundColorHTML = ColorTranslator.ToHtml(settings.BackgroundColor);
            settings.sForeColorHTML = ColorTranslator.ToHtml(settings.ForeColor);

            XmlSerializer serializer = new XmlSerializer(typeof(Settings));
            using (TextWriter writer = new StreamWriter(_appConfPath + "settings"))
                serializer.Serialize(writer, settings);
        }

        public static Settings Deserialize()
        {
            Directory.CreateDirectory(_appConfPath);

            XmlSerializer deserializer = new XmlSerializer(typeof(Settings));
            Settings settings;

            try
            {
                using (TextReader reader = new StreamReader(_appConfPath + "settings"))
                {
                    object obj = deserializer.Deserialize(reader);
                    settings = (Settings)obj;
                    settings.BackgroundColor = ColorTranslator.FromHtml(settings.sBackgroundColorHTML);
                    settings.ForeColor = ColorTranslator.FromHtml(settings.sForeColorHTML);
                }
            }
            catch (Exception)
            {
                settings = new Settings();
            }
            
            return settings;
        }
        #endregion
    }
}