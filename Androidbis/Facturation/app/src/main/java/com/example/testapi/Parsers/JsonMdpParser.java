package com.example.testapi.Parsers;

import android.util.Log;

import com.example.testapi.Models.ModeDePaiement;
import com.example.testapi.Personnes;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.List;

public class JsonMdpParser {
    public static  List<ModeDePaiement> parseListeMdp(String json) throws JSONException {
        List<ModeDePaiement> listeMdp= new ArrayList<ModeDePaiement>();
        try {
            JSONObject jObj = new JSONObject(json);
            //JSONArray tabRep = new JSONArray(jObj.get("hydra:member"));
            Log.d("*********************** JSON ******************************", "parseListeMdp: "+jObj.getJSONArray("hydra:member").length());
            for (int i=0;i<jObj.getJSONArray("hydra:member").length();i++)
            {
                ModeDePaiement mdp = new ModeDePaiement(((JSONObject)jObj.getJSONArray("hydra:member").get(i)).getString("libelle"));
                listeMdp.add(mdp);
                Log.d("*********************** JSON ******************************", "parseListeMdp: "+mdp);

            }
        }
        catch (Exception e){}

//            JSONObject jObj = new JSONObject(json);
//            mdp.SetLibelle(jObj.getString("libelle"));

        return  listeMdp;
    }
}
