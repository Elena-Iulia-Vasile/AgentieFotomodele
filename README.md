# AgentieFotomodele

Aplicatie ce va reprezenta o agentie de fotomodele construita cu C#, WindowsForms si SQL Server.

Aplicatia poate fi rulata local. Pentru a o putea rula trebuie descarcate toate sursele si pentru baza de date facut restore.

Backup-ul la baza de date se gaseste in folderul AdditionalInformation.

!!! Atentie la versiunea folosita de SQL Server, eu am folosit versiunea 12.0.5223.

Conexiunea la baza de date se va face printr-un connection string pe care il veti seta intr-un fisier App.config
App.config va arata in felul acesta:

<?xml version="1.0"?>
<configuration>
    <connectionStrings>   
        <add name="MyKey" 
             connectionString="" //de adaugat 
             providerName=""/>  //de adaugat, le puteti lua din sql server
    </connectionStrings>
</configuration>
