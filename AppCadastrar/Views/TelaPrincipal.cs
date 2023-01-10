using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using AppCadastrar.Views;
using System;
using System.Threading.Tasks;

namespace AppCadastrar
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class TelaPrincipal : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.TelaPrincipal);

            Button telaPrincipal = FindViewById<Button>(Resource.Id.btnCadastro);
            Button telaAlterar = FindViewById<Button>(Resource.Id.btnAlterar);
            Button telaRemover = FindViewById<Button>(Resource.Id.btnRemover);
            Button telaExibir = FindViewById<Button>(Resource.Id.btnExibir);

            telaPrincipal.Click += delegate
            {
                StartActivity(typeof(TelaCadastrar));
            };

            telaAlterar.Click += delegate
            {
                StartActivity(typeof(TelaAlterar));
            };
            telaRemover.Click += delegate
            {
                StartActivity(typeof(TelaDeletar));
            };

            telaExibir.Click += delegate
            {
                StartActivity(typeof(TelaListaFuncionarios));
            };
        }
    }
}
