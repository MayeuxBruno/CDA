<?php
class Employe
{
    /*****************Attributs***************** */
    private $_nom;
    private $_prenom;
    private $_dateEmbauche;
    private $_fonction;
    private $_salaireAnnuel;
    private $_service;
    private $_agence;
    private static $nbEmployes=0;

    /*****************Accesseurs***************** */
    public function getNom()
    {
        return $this->_nom;
    }

    public function setNom($nom)
    {
        $this->_nom = $nom;
    }
    public function getPrenom()
    {
        return $this->_prenom;
    }

    public function setPrenom($prenom)
    {
        $this->_prenom = $prenom;
    }

    public function getDateEmbauche()
    {
        return $this->_dateEmbauche;
    }

    public function setDateEmbauche($dateEmbauche)
    {
        $this->_dateEmbauche = $dateEmbauche;
    }

    public function getFonction()
    {
        return $this->_fonction;
    }

    public function setFonction($fonction)
    {
        $this->_fonction = $fonction;
    }

    public function getSalaireAnnuel()
    {
        return $this->_salaireAnnuel;
    }

    public function setSalaireAnnuel($salaireAnnuel)
    {
        $this->_salaireAnnuel = $salaireAnnuel;
    }

    public function getService()
    {
        return $this->_service;
    }

    public function setService($service)
    {
        $this->_service = $service;
    }

    public static function getNbEmployes()
    {
        return self::$nbEmployes;
    }

    public static function setNbEmployes($nbEmployes)
    {
        self::$nbEmployes = $nbEmployes;
    }

    public function getAgence()
    {
        return $this->_agence;
    }

    public function setAgence(Agence $agence)
    {
        $this->_agence = $agence;
    }
    
    /*****************Constructeur***************** */

    public function __construct(array $options = [])
    {
        self::setNbEmployes(self::getNbEmployes()+1);
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
        return  "<br>****** Salarie ******
                 <br> Nom : ".$this->getNom().
                "<br> Prenom : ".$this->getPrenom().
                "<br> Date Embauche : ".$this->getDateEmbauche()->format('d-m-Y').
                "<br> Fonction : ".$this->getFonction().
                "<br> Salaire brut Annuel : ".$this->getSalaireAnnuel().
                "<br> Service : ".$this->getService().
                $this->getAgence()->ToString();;
    }

    public function anciennete()
    {
        $dateActuelle = new DateTime('now');
        return date_diff($dateActuelle,$this->getDateEmbauche())->format('%y')*1;
    }

    public function prime()
    {
        return round($this->getSalaireAnnuel()*1000*0.05+$this->anciennete()*1000*0.02,2);
    }

    public function masseSalariale()
    {
        return $this->getSalaireAnnuel()*1000+$this->prime();
    }

    public static function triParNomPrenom($empA,$empB)
    {
        if ($empA->getNom()>$empB->getNom())
        {
            return 1;
        }
        else if($empA->getNom()<$empB->getNom())
        {
            return -1;
        }
        else if ($empA->getPrenom()>$empB->getPrenom())
        {
                return 1;
        }
        else if($empA->getPrenom()<$empB->getPrenom())
        {
            return -1;
        }
        return 0;
    }

    public static function triParServiceNomPrenom($empA,$empB)
    {
        if ($empA->getService()>$empB->getService())
        {
            return 1;
        }
        else if ($empA->getService()<$empB->getService())
        {
            return -1;
        }
        else{
            self::triParNomPrenom($empA,$empB);
        }
    }


   
}