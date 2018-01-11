﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MuscleTrainingRecords00;

namespace MuscleTrainingRecords00
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecordPage : ContentPage
    {
        DateTime yyyymmdd;

        public RecordPage()
        {
            InitializeComponent();
        }


        private void Insert_Clicked(object sender, EventArgs e)
        {

            int RecordsAllText = int.Parse(Weight.Text, Leg.Text, Set.Text, yymmdd);

            //RecordsModel.InsertRecords(Weight.Text, Leg.Text, Set.Text, yyyymmdd);//試し
            RecordsModel.InsertRecords(RecordsAllText);

            DisplayAlert("", "保存されました", "OK");

            Navigation.PushAsync(new RecordListPage());
        }
        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            yyyymmdd = new DateTime(DatePicker.Date.Year, DatePicker.Date.Month, DatePicker.Date.Day);


        }
    }
}
