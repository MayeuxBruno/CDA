<?php
class Agence
{

    /*****************Attributs***************** */
    private $_nomAgence;
    private $_adresse;
    private $_codePostal;
    private $_ville;
    private $_restauration;

    /*****************Accesseurs***************** */

    public function getNomAgence()
    {
        return $this->_nomAgence;
    }

    public function setNomAgence($nomAgence)
    {
        $this->_nomAgence = $nomAgence;
    }

    public function getAdresse()
    {
        return $this->_adresse;
    }

    public function setAdresse($adresse)
    {
        $this->_adresse = $adresse;
    }

    public function getCodePostal()
    {
        return $this->_codePostal;
    }

    public function setCodePostal($codePostal)
    {
        $this->_codePostal = $codePostal;
    }

    public function getVille()
    {
        return $this->_ville;
    }

    public function setVille($ville)
    {
        $this->_ville = $ville;
    }
    public function getRestauration()
    {
        return $this->_restauration;
    }

    public function setRestauration($restauration)
    {
        $this->_restauration = $restauration;
    }
    
    /*****************Constructeur***************** */

    public function __construct(array $options = [])
    {
        if (!empty($options)) // empty : renvoi vrai si le tableau est vide
        {
            $this->hydrate($options);
        }
    }
    public function hydrate($data)
    {
        foreach ($data as $key => $value)
        {
            $methode = "set" . ucfirst($key); //ucfirst met la 1ere lettre en majuscule
            if (is_callable(([$this, $methode]))) // is_callable verifie que la methode existe
            {
                $this->$methode($value);
            }
        }
    }

    /*****************Autres Méthodes***************** */
    
    /**
     * Transforme l'objet en chaine de caractères
     *
     * @return String
     */
    public function toString()
    {
        $string= "<br>***** Agence *****
                  <br> Nom : ".$this->getNomAgence().
                 "<br> Adresse : ".$this->getAdresse().
                 "<br> Code Postal : ".$this->getCodePostal().
                 "<br> Ville : ".$this->getVille();
        if ($this->getRestauration())
        {
            $string=$string."<br> Restauration : Restaurant d'entreprise";
        }
        else{
            $string=$string."<br> Restauration : Ticket Restaurant";
        }
        return $string;
    }


   

    
}