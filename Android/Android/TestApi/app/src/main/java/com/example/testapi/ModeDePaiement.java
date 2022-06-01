package com.example.testapi;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.net.ConnectivityManager;
import android.net.NetworkInfo;
import android.os.AsyncTask;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.view.inputmethod.InputMethodManager;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import com.example.testapi.models.ModeDePaiement_model;

public class ModeDePaiement extends AppCompatActivity {

    // On déclare les variables dans la classe pour les récupérer plus facilment

    private ListView liste;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        // au lancement de l'application
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_mode_de_paiement);
        liste = (ListView)findViewById(R.id.liste);
       // on récupère les contrôles de la view
//        ModeDePaiement_model mdp1 = new ModeDePaiement_model("Espece");
//        ModeDePaiement_model mdp2 = new ModeDePaiement_model("Liquide");
//        ModeDePaiement_model[] listeMdp = new ModeDePaiement_model[]{mdp1,mdp2};

        ArrayAdapter<ModeDePaiement_model> arrayAdapter = new ArrayAdapter<ModeDePaiement_model>(this,R.layout.listeitem_mode_paiement,R.id.textViewItem,listeMdp);
        liste.setAdapter(arrayAdapter);
        // on pose un listener sur le bouton
//        btnLancer.setOnClickListener(new View.OnClickListener() {
//            @Override
//            public void onClick(View view) {
//                //on lance la requête ajax
//                sendRequest(btnLancer);
//            }
//        });
    }


    //méthode qui vérifie si le réseau est disponible
    private Boolean isNetworkAvailable() {
        ConnectivityManager connectivityManager
                = (ConnectivityManager) getSystemService(Context.CONNECTIVITY_SERVICE);
        NetworkInfo activeNetworkInfo = connectivityManager.getActiveNetworkInfo();
        return activeNetworkInfo != null && activeNetworkInfo.isConnectedOrConnecting();
    }

    //méthode de vérification si internet est disponible
    public Boolean isOnline() {
        try {
            Process p1 = java.lang.Runtime.getRuntime().exec("ping -c 1 www.google.com");
            int returnVal = p1.waitFor();
            boolean reachable = (returnVal == 0);
         return reachable;
     } catch (Exception e) {
         e.printStackTrace();
     }
     return false;
 }
////
 /**
  * Lancement de la recherche
  */
 public void sendRequest(View view) {
//
     InputMethodManager imm = (InputMethodManager) getSystemService(Context.INPUT_METHOD_SERVICE);
     if (isNetworkAvailable()) {
         if (isOnline()) {
             // On a accès au réseau et à internet
             // On récupère l'id du mode de paiement et on enlève les espaces
//             EditModePaiement.setText(EditModePaiement.getText().toString().trim());
//             Log.d("Test", "******************onSendRequest: idModeDePaiement : " + EditModePaiement.getText());
             imm.hideSoftInputFromWindow(view.getWindowToken(), 0);
             //  on lance une tâche asynchrone en fonction de la saisie
             AppelAPI task = new AppelAPI();
//             task.execute(EditModePaiement.getText().toString());
         } else {
             Toast.makeText(view.getContext(), getApplicationContext().getResources().getString(R.string.no_online), Toast.LENGTH_LONG);
         }
     } else {
         Toast.makeText(view.getContext(), getApplicationContext().getResources().getString(R.string.no_network), Toast.LENGTH_LONG);
     }
 }
//
//
 private class AppelAPI extends AsyncTask<String, Void, String> {
//
     @Override
     protected String doInBackground(String... params) {
         //la requête doit nous retourner un objet JSON, ici on va le gérer en string simple
         String retour = new String();
         String data = "";
//
         //exécution de la requête http avec en paramètres l'id saisi ou pas
         data = ((new ApiHttpClient()).getListeMPData());
         if (data != null) {
             Log.d("test", " retour:" + data);
             //on log et on renvoi les données
             return data;
         } else {
             return null;
         }
//
     }
//
     @Override
     protected void onPostExecute(String data) {
         super.onPostExecute(data);
         //si l'objet retourné n'est pas null on affiche le résultat brut
         if (data != null) {
//             reponse.setText(data);
             //le mieux serait d'extraire les données du json et de les présenter
             // voire créer un objet de type personnes , caster les données et remplir les contrôles de la view
         }
     }
 }
}