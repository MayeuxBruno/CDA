package com.example.testapi.Models;

public class ModeDePaiement {
    private String libelle;

    public ModeDePaiement(String libelle)
    {
        this.libelle=libelle;
    }

    public ModeDePaiement()
    {

    }

    public String GetLibelle()
    {
        return this.libelle;
    }
    public void SetLibelle(String libelle)
    {
        this.libelle=libelle;
    }

    public String ToString()
    {
        return this.libelle;
    }
}
