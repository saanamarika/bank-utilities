using System;
using System.Collections.Generic;
using System.Text;

namespace Pank
{
    class ClassBBAN
    {
        private string _account;
        private string _isvalid;

        public ClassBBAN(string account)
        {
            _account = account;
        }
    }
}
//Sovelluksen tulee tukea suomalaisen BBAN-muotoisen tilinumeron muuntamista perusmuodostaan konekieliseen muotoon 
//ja tilinumeron tarkisteen tarkistamista.Suomalainen BBAN-muotoinen tilinumero koostuu perusmuodossaan 6 numerosta, 
//väliviivasta ja 2-8 numerosta.Käyttäjä voi syöttää tilinumeron väliviivalla tai ilman. Sovellus muuntaa syötetyn 
//tilinumeron konekieliseen muotoon ja laskee syötetyn tilinumeron tarkisteen, jonka perusteella tarkistetaan, että 
//syötetty tilinumeron on oikea. Sovellus tulostaa käyttäjän syöttämän tilinumeron konekielisessä muodossa ja tiedon siitä,
//onko tilinumeron tarkiste oikea.
//Määrittelyt

//SUOMALAISTEN TILINUMEROIDEN RAKENNE JA TARKISTE 1.11.2009

//SUOMALAISTEN TILINUMEROIDEN RAKENNE JA TARKISTE

//Suomalaiset tilinumerot koostuvat pankin tai pankkiryhmän (liikepankkien, säästöpankkien, osuuspankkien ja 
//paikallisosuuspankkien) numerosta, tililajista, tilin numerosta ja tarkistusnumerosta eli tarkisteesta.Tilinumeron 
//kaksi ensimmäistä numeroa ilmaisevat pankin tai pankkiryhmän seuraavasti (nimilyhenne sulkeissa):

//1 = Nordea Pankki (Nordea)
//2 = Nordea Pankki (Nordea)
//31 = Handelsbanken
//33 = Skandinaviska Enskilda Banken (SEB)
//34 = Danske Bank
//36 = Tapiola Pankki
//37 = DnB NOR Bank ASA (DnB NOR)
//38 = Swedbank
//39 = S-Pankki
//4 = Aktia Pankki, Säästöpankit (Sp) ja Paikallisosuuspankit (POP)
//5 = OP-Pohjola-ryhmä (Osuuspankit (OP), Helsingin OP Pankki ja Pohjola Pankki)
//6 = Ålandsbanken ÅAB)
//8 = Sampo Pankki

//Tilinumero on korkeintaan 14 numeroa pitkä, ja se merkitään selväkielisessä muodossa kahdessa osassa, joiden välissä 
//on yhdysmerkki.Ensimmäinen osa on aina kuuden numeron mittainen, ja toisen osan pituus vaihtelee 2 - 8 numeroon.
//Tilinumeron viimeinen numero on tarkiste.

//Tilinumeroiden muuttaminen konekieliseen muotoon

//Konekielinen maksujenvälitys ja pankkiviivakoodi sekä tilinumeron tarkisteen laskenta edellyttävät tilinumeron 
//konekielistä muotoa.Sitä varten selväkieliset tilinumerot täydennetään 14 numeron mittaisiksi (tilinumeroosien 
//välinen yhdysmerkki jätetään pois) seuraavien pankkiryhmittäisten sääntöjen mukaisesti:

//Nordea, Handelsbanken, SEB, Danske Bank, Tapiola Pankki, DnB NOR, Swedbank, S-Pankki, ÅAB ja Sampo Pankki

//Näiden pankkien tilinumerot täydennetään nollilla vasemmalta lukien kuuden numeron jälkeen siten, että 14 numeroa täyttyy.

//Esimerkki 123456-785 tilinumero selväkielisessä muodossa 12345600000785 nollilla 14-numeroiseksi täydennetty tilinumero

//Aktia Pankki, Säästöpankit (Sp), Paikallisosuuspankit (POP) ja OPPohjola-ryhmä (osuuspankit (OP), Helsingin OP Pankki ja 
//Pohjola Pankki

//Näiden pankkien tilinumerot täydennetään nollilla vasemmalta lukien seitsemännen numeron jälkeen siten, että 14 numeroa 
//täyttyy.

//Esimerkki 423456-781 tilinumero selväkielisessä muodossa 42345670000081 nollilla 14-numeroiseksi täydennetty tilinumero

//Tilinumeron tarkisteen laskenta

//Tilinumeron tarkiste lasketaan Luhnin modulolla 10 painoin 2, 1, 2, 1 .. oikealta vasemmalle. Laskennassa käytetään 
//tilinumeron konekielisen muodon 13 ensimmäistä numeroa. Numerot kerrotaan painoillaan.Näin saatujen tulojen numerot 
//lasketaan yhteen. Summa vähennetään seuraavasta kymmenellä jaollisesta luvusta. Saatu erotus on tarkiste, joka merkitään 
//tilinumeron viimeiseksi eli 14. numeroksi.

//Esimerkki tilinumeron tarkisteen laskemisesta 1 2 3 4 5 6 0 0 0 0 0 7 8 5 tilinumeron konekielinen muoto 1234560000078 
//lasketaan mukaan otettavat numerot 2121212121212 painot 2 2 6 4 10 6 0 0 0 0 0 7 16 
//tulot 2+2+6+4+1+0+6+0+0+0+0+0+7+1+6 = 35 tulojen numerot yhteensä 40 - 35 = 5 tarkiste
