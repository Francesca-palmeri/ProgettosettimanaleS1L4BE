using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProgettosettimanaleS1L4BE.Models
{
    public class Contribuente
{

    public string Nome { get; set; }
    public string Cognome { get; set; }
    public string DataNascita { get; set; }
    public string CodiceFiscale { get; set; }
    public Genere Sesso { get; set; }
    public string ComuneResidenza { get; set; }
    public double RedditoAnnuale { get; set; }


    public Contribuente(string nome, string cognome, string dataNascita, string codiceFiscale, Genere sesso, string comuneResidenza, double redditoAnnuale)
    {
        Nome = nome;
        Cognome = cognome;
        DataNascita = dataNascita;
        CodiceFiscale = codiceFiscale;
        Sesso = sesso;
        ComuneResidenza = comuneResidenza;
        RedditoAnnuale = redditoAnnuale;
    }


    public double CalcolaImposta()
    {
        double reddito = RedditoAnnuale;
        double imposta = 0.0;


        if (reddito <= 15000)
        {
            imposta = reddito * 0.23;
        }
        else if (reddito <= 28000)
        {
            imposta = 3450 + (reddito - 15000) * 0.27;
        }
        else if (reddito <= 55000)
        {
            imposta = 6960 + (reddito - 28000) * 0.38;
        }
        else if (reddito <= 75000)
        {
            imposta = 17220 + (reddito - 55000) * 0.41;
        }
        else
        {
            imposta = 25420 + (reddito - 75000) * 0.43;
        }

        return imposta;
    }


    public override string ToString()
    {

        return $"Contribuente: {Nome} {Cognome}, nato il {DataNascita} ({Sesso}), residente in {ComuneResidenza}, codice fiscale: {CodiceFiscale}, Reddito dichiarato: {RedditoAnnuale:F2}, IMPOSTA DA VERSARE: € {CalcolaImposta():F2}";
    }
}
}