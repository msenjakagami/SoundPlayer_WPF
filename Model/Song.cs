using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;


namespace SoundPlayer_WPF.Model
{
    public class Song : ObservableObject
    {

        private string title;
        private string artist;
        private string album;
        private string genre;
        private string path;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                Set<string>(() => this.Title, ref title, value);
            }
        }

        public string Artist
        {
            get
            {
                return artist;
            }
            set
            {
                Set<string>(() => this.Artist, ref artist, value);
            }
        }

        public string Album
        {
            get
            {
                return album;
            }
            set
            {
                Set<string>(() => this.Album, ref album, value);
            }
        }

        public string Genre
        {
            get
            {
                return genre;
            }
            set
            {
                Set<string>(() => this.Genre, ref genre, value);
            }
        }

        public string Path
        {
            get
            {
                return path;
            }
            set
            {
                Set<string>(() => this.Path, ref path, value);
            }
        }
    }
}
