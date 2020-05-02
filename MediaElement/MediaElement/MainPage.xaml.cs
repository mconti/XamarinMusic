using MediaElement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MediaElement
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        Brani Brani = new Brani();

        public MainPage()
        {
            // Help sull'uso del MediaElement
            // https://www.telerik.com/blogs/how-to-use-the-mediaelement-in-xamarin-forms

            Device.SetFlags(new string[] { "MediaElement_Experimental" });
            InitializeComponent();

            BindingContext = Brani;
        }

        private void btnPlayStop_Clicked(object sender, EventArgs e)
        {
            // Autore
            // Metre
            // Broke For Free

            // Titolo
            // Sand Dweller
            // Night Owl

            // Immagine
            // https://files.freemusicarchive.org/storage-freemusicarchive-org/images/artists/Metre_-_2018102225915098.jpg?width=290&height=290
            // https://files.freemusicarchive.org/storage-freemusicarchive-org/images/artists/Broke_For_Free_-_2013011621055318.jpg?width=290&height=290


            // MP3
            // https://files.freemusicarchive.org/storage-freemusicarchive-org/music/Nul_Tiel_Records/Metre/Motif/Metre_-_03_-_Sand_Dweller.mp3
            // https://files.freemusicarchive.org/storage-freemusicarchive-org/music/WFMU/Broke_For_Free/Directionless_EP/Broke_For_Free_-_01_-_Night_Owl.mp3

            try
            {
                if (media.CurrentState == MediaElementState.Playing)
                {
                    media.Stop();
                    //btnPlayStop.Text = "Play";
                }
                else
                {
                    
                    media.Source = "https://files.freemusicarchive.org/storage-freemusicarchive-org/music/Nul_Tiel_Records/Metre/Motif/Metre_-_03_-_Sand_Dweller.mp3";
                    //media.Source = "ms-appx:///Metre.mp3";
                    media.Play();
                    //btnPlayStop.Text = "Stop";
                }
            }
            catch( Exception err)
            { DisplayAlert("Errore", err.Message, "ok"); }
        }

        private void ImageCell_Tapped(object sender, EventArgs e)
        {
            var s = sender as ImageCell;
            if( s != null )
            {
                var brano = s.CommandParameter as Brano;
                if( brano != null )
                {
                    try
                    {
                        if (media.CurrentState == MediaElementState.Playing)
                            media.Stop();

                        media.Source = brano.Mp3;
                        media.Play();
                    }
                    catch (Exception err)
                    { DisplayAlert("Errore", err.Message, "ok"); }
                }
            }
        }

        private void lvBrani_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var brano = e.SelectedItem as Brano;
            if (brano != null)
            {
                try
                {
                    if (media.CurrentState == MediaElementState.Playing)
                        media.Stop();

                    media.Source = brano.Mp3;
                    media.Play();
                }
                catch (Exception err)
                { DisplayAlert("Errore", err.Message, "ok"); }
            }
        }

        private void lvBrani_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //if (media.CurrentState == MediaElementState.Playing)
            //    media.Pause();
            //else
            //    media.Play();

        }
    }
}
