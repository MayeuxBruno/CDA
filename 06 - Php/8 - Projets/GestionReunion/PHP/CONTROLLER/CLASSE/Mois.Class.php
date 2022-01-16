<?php
Class Mois
{

    private $_tabJours = ['Lundi','Mardi','Mercredi','Jeudi','Vendredi','Samedi','Dimanche'];
    private $_tabMois=['Janvier','Février','Mars','Avril','Mai','Juin','Juillet','Aout','Septembre','Octobre','Novembre','Décembre'];
    private $_mois;
    private $_annee;

/*******  Aceesseurs ********/

    public function getMois()
    {
        return $this->_mois;
    }

    public function setMois($mois)
    {
        $this->_mois = $mois;
    }

    public function getAnnee()
    {
        return $this->_annee;
    }

    public function setAnnee($annee)
    {
        $this->_annee = $annee;
    }

    public function getTabMois()
    {
        return $this->_tabMois;
    }

    public function setTabMois($tabMois)
    {
        $this->_tabMois = $tabMois;
    }

    public function getTabJours()
    {
        return $this->_tabJours;
    }

    public function setTabJours($tabJours)
    {
        $this->_tabJours = $tabJours;
    }

/******* Constructeur *******/

    public function __construct(?int $mois =null, ?int $annee=null)
    {
        if($mois===null)
        {
            $mois= intval(date('m'));
        }
        if($annee===null)
        {
            $annee= intval(date('Y'));
        }
        if ($mois<1 || $mois>12)
        {
            throw new exception ("Le mois $mois n'est pas valide"); 
        }
        if ($annee<1970)
        {
            throw new exception ("L'année $annee est inférieur à 1970"); 
        }
        $this->setMois($mois);
        $this->setAnnee($annee);
    }

    public function ToString()
    {
        return $this->getTabMois()[($this->getMois())-1]." ".$this->getAnnee();
    }

    public function estDansLeMois(DateTime $date)
    {
        return $this->jourDeDepart()->format('Y-m')===$date->format('Y-m');
    }

    public function jourDeDepart()
    {
        return new DateTime("{$this->getAnnee()}-{$this->getMois()}-01");  // On définit la date du premier jour du mois
    }

    public function moisSuivant()
    {
        $mois=$this->getMois()+1;
        $annee=$this->getAnnee();
        if($mois>12)
        {
            $mois=1;
            $annee++;
        }
        return new Mois($mois,$annee);
    }

    public function moisPrecedent()
    {
        $mois=$this->getMois()-1;
        $annee=$this->getAnnee();
        if($mois<1)
        {
            $mois=12;
            $annee--;
        }
        return new Mois($mois,$annee);
    }

    public function nbSemaines()
    {
        $debut= $this->jourDeDepart();  
        $fin = (clone $debut)->modify('+1 month -1day');          // On rajoute 1 mois moins 1 jours pour avoir la date du dernier jours du mois. La fonction clone permet que la date de debut ne soit pas modifier par modify
        $nbSemaines = intval($fin->format('W')- $debut->format('W'))+1;
        if($nbSemaines<0)
        {
            $nbSemaines=intval($fin->format('W'))+1;
        }
        return $nbSemaines;
    }
}