﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using TIFA.Models;
using TIFA.ViewModels;

namespace TIFA.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class NewItemPage : ContentPage
    {
        public ItemsViewModel ViewModel { get;  }

        public Placar Item { get; set; }

        public NewItemPage(ItemsViewModel viewModel)
        {
            InitializeComponent();

            Item = new Placar();
            ViewModel = viewModel;

            BindingContext = this;

        }

        async void Save_Clicked(object sender, EventArgs e)
        {

            if (Item.JogadorA == null || Item.JogadorB == null ||
                Item.JogadorAGols == null || Item.JogadorBGols == null)
            {
                await DisplayAlert("Atenção", "Todos os campos são obrigatórios", "Ok");
                return;
            }

            MessagingCenter.Send(this, "AddItem", Item);
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }


    }
}