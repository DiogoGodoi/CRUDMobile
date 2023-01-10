using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.RecyclerView.Widget;
using Controlador;
using Funcionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCadastrar.Views
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class TelaListaFuncionarios : AppCompatActivity
    {
        ListView lista;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.TelaFuncionarios);

            List<string> lFuncionario = new List<string>();
            var dados = controlador.read();

            foreach (var dado in dados)
            {
                lFuncionario.Add($"{dado.getCracha()} - {dado.getNome()} - {dado.getSetor()} - {dado.getCargo()}");
            }

            lista = FindViewById<ListView>(Resource.Id.listaFuncionario);
            ArrayAdapter adaptdador = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, lFuncionario);
            lista.Adapter = adaptdador;

                        
        }

    }
}