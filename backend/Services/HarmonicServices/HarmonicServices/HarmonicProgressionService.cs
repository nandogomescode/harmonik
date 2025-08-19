using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonicModels;

namespace HarmonicServices.HarmonicProgression
{
    public class HarmonicProgressionService
    {

        private string tone { get; set; }

        /*Constructor*/
        public HarmonicProgressionService(String tone)
        {

            this.tone = tone;

        }

        public void SetHarmonicProgression()
        {

            float result = 0.0f;

            List<NotesModel> outParam = new List<NotesModel>();
            MajorScaleModel majorScale = new MajorScaleModel();
            NotesModel notes = new NotesModel();

            float[] fields = { majorScale.supertonic, majorScale.mediant, majorScale.submediant, majorScale.dominant, majorScale.leading, majorScale.oct };
            float[] noteArray = { notes.C, notes.Cs, notes.D, notes.Ds, notes.E, notes.F, notes.Fs, notes.G, notes.Gs, notes.A, notes.As, notes.B };

            majorScale.tonic = notes.C; 

            for(int i = 0; i < fields.Length; i++)
            {

                noteArray[i] += fields[i];

            }
            

        }

        public enum IMajorScale
        {

            tonic = 1,      //1st
            supertonic = 1, //2nd
            mediant = 0,    //3rd
            subdminant = 1, //4th
            dominant = 1,   //5th
            submediant = 1, //6th
            leading = 1,    //7th
            oct = 1         //8th

        }

    }
}
