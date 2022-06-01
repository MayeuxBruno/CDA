package com.example.testapi.models;

public class ModeDePaiement_model {
    private String Libelle;

    public ModeDePaiement_model(String libelle)
    {
        this.Libelle=libelle;
    }

    public String GetLibelle()
    {
        return this.Libelle;
    }

    @Override
    public String toString(){
        return this.Libelle;
    }
}
