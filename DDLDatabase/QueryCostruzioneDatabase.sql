create table ACCESSI_INVENTARIO (
     IDDipendente int not null,
     DataOra datetime not null,
     IDStruttura int not null,
     IDGarage int,
     IDMagazzino int,
     IDSerraIncubazione int,
     constraint ID_ACCESSI_INVENTARIO primary key (IDDipendente, DataOra));

create table ANNOTAZIONI (
     IDEsperimento int not null,
     NumeroAnnotazione int not null,
     DataOra datetime not null,
     Testo varchar(200) not null,
     IDRicercatore int not null,
     constraint ID_ANNOTAZIONE primary key (IDEsperimento, NumeroAnnotazione));

create table CLIMI (
     IDClima int IDENTITY(1,1) not null,
     Nome varchar(50) not null,
     Descrizione varchar(200) not null,
     Luce varchar(50) not null,
     OreLuce int not null,
     Umidità int not null,
     Temperatura int not null,
     constraint ID_CLIMI primary key (IDClima));

create table CLUSTER (
     IDStruttura int not null,
     IDSerra int not null,
     IDCluster int not null,
     Dimensione varchar(50) not null,
     ComposizioneNPKTerreno varchar(50) not null,
     constraint CHK_DIMENSIONE check (Dimensione = 'piccolo' or Dimensione = 'medio' or Dimensione = 'grande')
     constraint ID_CLUSTER primary key (IDStruttura, IDSerra, IDCluster));

create table CLUSTER_EMBRIONI (
     IDPianta int not null,
     IDClusterEmbrioni int not null,
     DataSemina datetime not null,
     DataGerminazione datetime,
     DataUscita datetime,
     EmbrioniFalliti int default 0,
     IDStruttura int not null,
     IDSerraIncubazione int not null,
     constraint CHK_DATA_CLUSTER_EMBRIONI (DataSemina<DataGerminazione and DataGerminazione<DataUscita)
     constraint ID_CLUSTER_EMBRIONI primary key (IDPianta, IDClusterEmbrioni));

create table CLUSTER_PIANTE (
     IDClusterPiante int not null IDENTITY(1,1),
     DataInizio datetime not null,
     DataFine datetime not null,
     DataTrapianto datetime not null,
     DataEspianto datetime,
     NumeroPianteIniziali int not null,
     NumeroPianteMorte int default 0,
     TrattamentoBiologico varchar(50) default 'biologico',
     DataSmaltimento datetime,
     IDStruttura int not null,
     IDSerra int not null,
     IDCluster int not null,
     IDEsperimento int not null,
     IDPianta int not null,
     constraint CHK_DATA_CLUSTER_PIANTE (DataInizio<=DataTrapianto and DataInizio<DataEspianto and DataInizio<DataFine and DataInizio < DataSmaltimento
                                         and DataTrapianto<DataEspianto and DataTrapianto<DataFine and DataTrapianto<DataSmaltimento
                                         and DataEspianto<=DataFine and DataEspianto<=DataSmaltimento
                                         and DataFine<=DataSmaltimento)
     constraint CHK_TRATTAMENTO check (TrattamentoBiologico = 'biologico' or TrattamentoBiologico = 'tradizionale')
     constraint ID_CLUSTER_PIANTE primary key (IDClusterPiante));

create table COLLABORAZIONI (
     IDEsperimento int not null,
     IDRicercatore int not null,
     constraint ID_COLLABORAZIONI primary key (IDEsperimento, IDRicercatore));

create table CONTRATTI (
     IDContratto int not null IDENTITY(1,1),
     TipoContratto varchar(20) not null,
     DataInizio datetime not null,
     DataFine datetime,
     IDDipendente int not null,
     IDStruttura int not null,
     constraint CHK_DATA_CONTRATTO check (DataInizio<DataFine)
     constraint ID_CONTRATTO primary key (IDContratto));

create table DIPENDENTI (
     IDDipendente int not null IDENTITY(1,1),
     CF varchar(20) not null unique,
     Nome varchar(50) not null,
     Cognome varchar(50) not null,
     Provincia varchar(50) not null,
     CAP varchar(50) not null,
     Via varchar(50) not null,
     NumeroCivico varchar(20) not null,
     Telefono varchar(20) not null,
     Mail varchar(50) not null,
     Ruolo varchar(50) not null,
     Stipendio int not null,
     CV varchar(200) not null,
     AbilitazioneProdottiChimici varchar(15),
     IDStruttura int not null,
     constraint ID_DIPENDENTE primary key (IDDipendente));

create table ESPERIMENTI (
     IDEsperimento int not null IDENTITY(1,1),
     DataInizio datetime not null,
     DataFine datetime not null,
     DataApprovazione datetime not null,
     Descrizione varchar(200) not null,
     IDAutorizzante int not null,
     IDRicercatoreCapo int not null,
     constraint CHK_DATA_ESPERIMENTI (DataInizio<DataFine and DataInizio>DataApprovazione and DataApprovazione<DataFine)
     constraint ID_ESPERIMENTI_ID primary key (IDEsperimento));

create table GARAGE (
     IDStruttura int not null,
     IDGarage int not null,
     Nome varchar(50) not null,
     Dimensione int not null,
     ParcheggiTotali int not null,
     ParcheggiLiberi int not null,
     constraint ID_GARAGE primary key (IDStruttura, IDGarage));

create table IRRIGAZIONI (
     IDClusterPiante int not null,
     DataInizio datetime not null,
     OraInizio time not null,
     OraFine time not null,
     DataFine datetime,
     PressioneAcqua int not null,
     constraint CHK_DATA_IRRIGAZIONI (DataInizio<=DataFine and OraInizio<OraFine)
     constraint ID_IRRIGAZIONI primary key (IDClusterPiante, DataInizio, OraInizio));

create table LAVORI (
     IDLavoro int not null IDENTITY(1,1),
     Nome varchar(50) not null,
     Categoria varchar(50) not null,
     Descrizione varchar(200) not null,
     IDStruttura int,
     IDMagazzino int,
     IDProdotto int,
     constraint ID_LAVORI primary key (IDLavoro));

create table LAVORI_EFFETTUATI (
     IDLavoro int not null,
     IDLavoroEffettuato int not null,
     DataOraInizio datetime not null,
     DataOraFine datetime not null,
     IDClusterPiante int not null,
     IDManovale int not null,
     constraint CHK_DATA(DataOraInizio<=DataOraFine)
     constraint ID_LAVORI_EFFETTUATI primary key (IDLavoro, IDLavoroEffettuato));

create table MACCHINARI (
     NumeroTelaio varchar(50) not null,
     Marca varchar(50) not null,
     Modello varchar(50) not null,
     Targa varchar(50),
     DataRevisione datetime not null,
     LivelloCarburante int not null,
     IDStruttura int not null,
     IDGarage int not null,
     constraint ID_MACCHINARI primary key (NumeroTelaio));

create table MACCHINARI_UTILIZZATI (
     IDLavoro int not null,
     IDLavoroEffettuato int not null,
     NumeroTelaio varchar(50) not null,
     constraint ID_MACCHINARI_UTILIZZATI primary key (IDLavoro, IDLavoroEffettuato, NumeroTelaio));

create table MAGAZZINI (
     IDStruttura int not null,
     IDMagazzino int not null,
     Nome varchar(50) not null,
     Dimensione int not null,
     StoccaggioProdottiSensibili varchar(50),
     constraint ID_MAGAZZINI primary key (IDStruttura, IDMagazzino));

create table MANUTENZIONI (
     IDManutentore int not null,
     DataOra datetime not null,
     Descrizione varchar(200) not null,
     IDStruttura int not null,
     IDSerra int not null,
     constraint ID_MANUTENZIONI primary key (IDManutentore, DataOra));

create table PERMESSI_MACCHINARI (
     IDPermessoMacchinari int not null IDENTITY(1,1),
     DataCreazione datetime not null,
     Validità varchar(50) not null,
     NumeroTelaio varchar(50) not null,
     IDSupervisoreConcedente int not null,
     IDManovale int not null,
     constraint ID_PERMESSI_MACCHINARI primary key (IDPermessoMacchinari));

create table PERMESSI_SERRE (
     IDPermessoSerre int not null IDENTITY(1,1),
     DataCreazione datetime not null,
     Validità varchar(10) not null,
     IDSupervisoreConcedente int not null,
     IDStruttura int not null,
     IDSerra int not null,
     IDRicercatore int not null,
     constraint ID_PERMESSI primary key (IDPermessoSerre));

create table PERMESSI_STRUMENTI_COMPLESSI (
     IDPermessoStrumentiComplessi int not null IDENTITY(1,1),
     DataCreazione datetime not null,
     Validità varchar(50) not null,
     IDStruttura int not null,
     IDMagazzino int not null,
     IDStrumentoComplesso int not null,
     IDSupervisoreConcedente int not null,
     IDManovale int not null,
     constraint ID_PERMESSI_STRUMENTI_COMPLESSI primary key (IDPermessoStrumentiComplessi));

create table PIANTE (
     IDPianta int not null IDENTITY(1,1),
     Razza varchar(50) not null,
     Varietà varchar(50) not null,
     UnitàOccupate int not null,
     constraint ID_PIANTE primary key (IDPianta));

create table PRODOTTI (
     IDStruttura int not null,
     IDMagazzino int not null,
     IDProdotto int not null,
     Nome varchar(50) not null,
     Tipologia varchar(50) not null,
     PrincipioAttivo varchar(50) not null,
     Diluizione float(1) not null,
     GiorniEffetto int not null,
     Sensibile varchar(15),
     Quantità int not null,
     constraint CHK_Tipologia check (Tipologia = 'biologico' OR Tipologia = 'tradizionale'),
     constraint ID_PRODOTTI primary key (IDStruttura, IDMagazzino, IDProdotto));

create table RICERCATORI (
     IDRicercatore int not null IDENTITY(1,1),
     CF varchar(20) not null unique,
     Nome varchar(50) not null,
     Cognome varchar(50) not null,
     Provincia varchar(50) not null,
     CAP varchar(50) not null,
     Via varchar(50) not null,
     NumeroCivico varchar(20) not null,
     Telefono varchar(20) not null,
     Mail varchar(50) not null,
     Competenza varchar(50) not null,
     Dipartimento varchar(50) not null,
     NomeUniversità varchar(50) not null,
     constraint ID_RICERCATORI primary key (IDRicercatore));

create table SERRE (
     IDStruttura int not null,
     IDSerra int not null,
     Area int not null,
     NumeroUnitàMassime int not null,
     NumeroUnitàOccupate int default 0,
     IDClima int not null,
     constraint ID_SERRE_ID primary key (IDStruttura, IDSerra));

create table SERRE_INCUBAZIONE (
     IDStruttura int not null,
     IDSerraIncubazione int not null,
     Nome varchar(50) not null,
     Dimensione int not null,
     ClusterOspitabili int not null,
     ClusterPresenti int default 0,
     constraint ID_SERRE_INCUBAZIONE primary key (IDStruttura, IDSerraIncubazione));

create table STRUMENTI_COMPLESSI (
     IDStruttura int not null,
     IDMagazzino int not null,
     IDStrumentoComplesso int not null,
     Nome varchar(50) not null,
     Alimentazione varchar(50) not null,
     Quantità int not null,
     constraint CHK_ALIMENTAZIONE check (Alimentazione = 'benzina' or Alimentazione = 'diesel' or Alimentazione = 'elettrico')
     constraint ID_STRUMENTI_COMPLESSI primary key (IDStruttura, IDMagazzino, IDStrumentoComplesso));

create table STRUMENTI_COMPLESSI_UTILIZZATI (
     IDLavoro int not null,
     IDLavoroEffettuato int not null,
     IDStruttura int not null,
     IDMagazzino int not null,
     IDStrumentoComplesso int not null,
     constraint ID_STRUMENTI_COMPLESSI_UTILIZZATI primary key (IDLavoro, IDLavoroEffettuato, IDStruttura, IDMagazzino, IDStrumentoComplesso));

create table STRUTTURE (
     IDStruttura int not null IDENTITY(1,1),
     Nome varchar(50) not null,
     Provincia varchar(50) not null,
     CAP varchar(50) not null,
     Via varchar(50) not null,
     NumeroCivico varchar(20) not null,
     Telefono varchar(20) not null,
     DataInizioGestione datetime not null,
     IDDirettore int,
     constraint ID_STRUTTURA_ID primary key (IDStruttura));

create table SUPERVISIONI (
     IDSupervisore int not null,
     DataInizio datetime not null,
     DataFine datetime not null,
     IDStruttura int not null,
     IDSerra int not null,
     constraint CHK_DATA_SUPERVISIONI check (DataInizio<DataFine)
     constraint ID_SUPERVISIONI primary key (IDSupervisore, DataInizio));

create table UNIVERSITÀ  (
     Nome varchar(50) not null,
     Telefono varchar(20) not null,
     FAX varchar(20) not null,
     Mail varchar(50) not null,
     Provincia varchar(50) not null,
     CAP varchar(20) not null,
     Via varchar(50) not null,
     NumeroCivico varchar(20) not null,
     constraint ID_UNIVERSITÀ  primary key (Nome));

create table UTENSILI (
     IDStruttura int not null,
     IDMagazzino int not null,
     IDUtensile int not null,
     Nome varchar(50) not null,
     Descrizione varchar(50) not null,
     Quantità int not null,
     constraint ID_UTENSILI primary key (IDStruttura, IDMagazzino, IDUtensile));

create table VIAGGI_ISTRUZIONE (
     IDGuida int not null,
     IDViaggio int not null,
     Scuola varchar(50) not null,
     NumeroPartecipanti int not null,
     OrdineScolastico varchar(50) not null,
     constraint ID_VIAGGI_ISTRUZIONE primary key (IDGuida, IDViaggio));

create table VISITE (
     IDGuida int not null,
     IDViaggio int not null,
     DataOra datetime not null,
     IDStruttura int not null,
     IDSerra int not null,
     constraint ID_VISITE primary key (IDGuida, IDViaggio, DataOra));


-- Constraints Section
-- ___________________ 

alter table ACCESSI_INVENTARIO add constraint FKdipendenti_accessi_inventario
     foreign key (IDDipendente)
     references DIPENDENTI (IDDipendente);

alter table ACCESSI_INVENTARIO add constraint FKgarage_accessi_invetario
     foreign key (IDStruttura, IDGarage)
     references GARAGE (IDStruttura, IDGarage);

alter table ACCESSI_INVENTARIO add constraint FKmagazzini_accessi_inventari
     foreign key (IDStruttura, IDMagazzino)
     references MAGAZZINI (IDStruttura, IDMagazzino);

alter table ACCESSI_INVENTARIO add constraint FKserre_incubazione_accessi_inventario
     foreign key (IDStruttura, IDSerraIncubazione)
     references SERRE_INCUBAZIONE (IDStruttura, IDSerraIncubazione);

alter table ANNOTAZIONI add constraint FKesperimenti_annotazioni
     foreign key (IDEsperimento)
     references ESPERIMENTI (IDEsperimento);

alter table ANNOTAZIONI add constraint FKricercatori_annotazioni
     foreign key (IDRicercatore)
     references RICERCATORI (IDRicercatore);

alter table CLUSTER add constraint FKserre_cluster
     foreign key (IDStruttura, IDSerra)
     references SERRE (IDStruttura, IDSerra);

alter table CLUSTER_EMBRIONI add constraint FKserre_incubazione_cluster_embrioni
     foreign key (IDStruttura, IDSerraIncubazione)
     references SERRE_INCUBAZIONE (IDStruttura, IDSerraIncubazione);

alter table CLUSTER_EMBRIONI add constraint FKpiante_cluster_embrioni
     foreign key (IDPianta)
     references PIANTE (IDPianta);

alter table CLUSTER_PIANTE add constraint FKcluster_cluster_piante
     foreign key (IDStruttura, IDSerra, IDCluster)
     references CLUSTER (IDStruttura, IDSerra, IDCluster);

alter table CLUSTER_PIANTE add constraint FKesperimenti_cluster_piante
     foreign key (IDEsperimento)
     references ESPERIMENTI (IDEsperimento);

alter table CLUSTER_PIANTE add constraint FKpiante_cluster_piante
     foreign key (IDPianta)
     references PIANTE (IDPianta);

alter table COLLABORAZIONI add constraint FKricercatori_collaborazioni
     foreign key (IDRicercatore)
     references RICERCATORI (IDRicercatore);

alter table COLLABORAZIONI add constraint FKesperimenti_collaborazioni
     foreign key (IDEsperimento)
     references ESPERIMENTI (IDEsperimento);

alter table CONTRATTI add constraint FKdipendenti_contratti
     foreign key (IDDipendente)
     references DIPENDENTI (IDDipendente);

alter table CONTRATTI add constraint FKcontratti_strutture
     foreign key (IDStruttura)
     references STRUTTURE (IDStruttura);

alter table DIPENDENTI add constraint FKdipendente_lavora_presso
     foreign key (IDStruttura)
     references STRUTTURE (IDStruttura);

alter table ESPERIMENTI add constraint FKgestori_degli_esperimenti_esperimenti
     foreign key (IDAutorizzante)
     references DIPENDENTI (IDDipendente);

alter table ESPERIMENTI add constraint FKricercatori_capi_esperimenti
     foreign key (IDRicercatoreCapo)
     references RICERCATORI (IDRicercatore);

alter table GARAGE add constraint FKstrutture_garage
     foreign key (IDStruttura)
     references STRUTTURE (IDStruttura);

alter table IRRIGAZIONI add constraint FKcluster_irrigazioni
     foreign key (IDClusterPiante)
     references CLUSTER_PIANTE (IDClusterPiante);

alter table LAVORI add constraint FKlavori_prodotti_FK
     foreign key (IDStruttura, IDMagazzino, IDProdotto)
     references PRODOTTI (IDStruttura, IDMagazzino, IDProdotto);

alter table LAVORI add constraint FKlavori_prodotti_CHK
     check((IDStruttura is not null and IDMagazzino is not null and IDProdotto is not null)
           or (IDStruttura is null and IDMagazzino is null and IDProdotto is null)); 

alter table LAVORI_EFFETTUATI add constraint FKconsiste
     foreign key (IDLavoro)
     references LAVORI (IDLavoro);

alter table LAVORI_EFFETTUATI add constraint FKcluster_piante_lavori_effettuati
     foreign key (IDClusterPiante)
     references CLUSTER_PIANTE (IDClusterPiante);

alter table LAVORI_EFFETTUATI add constraint FKmanovali_lavori_effettuati
     foreign key (IDManovale)
     references DIPENDENTI (IDDipendente);

alter table MACCHINARI add constraint FKgarage_macchinari
     foreign key (IDStruttura, IDGarage)
     references GARAGE (IDStruttura, IDGarage);

alter table MACCHINARI_UTILIZZATI add constraint FKmacchinari_macchinari_utilizzati
     foreign key (NumeroTelaio)
     references MACCHINARI (NumeroTelaio);

alter table MACCHINARI_UTILIZZATI add constraint FKlavori_effettuati_macchinari_utilizzati
     foreign key (IDLavoro, IDLavoroEffettuato)
     references LAVORI_EFFETTUATI (IDLavoro, IDLavoroEffettuato);

alter table MAGAZZINI add constraint FKstrutture_magazzini
     foreign key (IDStruttura)
     references STRUTTURE (IDStruttura);

alter table MANUTENZIONI add constraint FKmanutentori_manutenzioni
     foreign key (IDManutentore)
     references DIPENDENTI (IDDipendente);

alter table MANUTENZIONI add constraint FKmanutenzioni_serre
     foreign key (IDStruttura, IDSerra)
     references SERRE (IDStruttura, IDSerra);

alter table PERMESSI_MACCHINARI add constraint FKmacchinari_permessi_macchinari
     foreign key (NumeroTelaio)
     references MACCHINARI (NumeroTelaio);

alter table PERMESSI_MACCHINARI add constraint FKpermessi_macchinari_supervisore_concedente
     foreign key (IDSupervisoreConcedente)
     references DIPENDENTI (IDDipendente);

alter table PERMESSI_MACCHINARI add constraint FKpermessi_macchinari_manovale
     foreign key (IDManovale)
     references DIPENDENTI (IDDipendente);

alter table PERMESSI_SERRE add constraint FKsupervisori_permessi
     foreign key (IDSupervisoreConcedente)
     references DIPENDENTI (IDDipendente);

alter table PERMESSI_SERRE add constraint FKpermessi_serre
     foreign key (IDStruttura, IDSerra)
     references SERRE (IDStruttura, IDSerra);

alter table PERMESSI_SERRE add constraint FKpermessi_serre_ricercatori
     foreign key (IDRicercatore)
     references RICERCATORI (IDRicercatore);

alter table PERMESSI_STRUMENTI_COMPLESSI add constraint FKstrumenti_complessi_permessi
     foreign key (IDStruttura, IDMagazzino, IDStrumentoComplesso)
     references STRUMENTI_COMPLESSI (IDStruttura, IDMagazzino, IDStrumentoComplesso);

alter table PERMESSI_STRUMENTI_COMPLESSI add constraint FKpermessi_strumenti_complessi_supervisore_concedente
     foreign key (IDSupervisoreConcedente)
     references DIPENDENTI (IDDipendente);

alter table PERMESSI_STRUMENTI_COMPLESSI add constraint FKpermessi_strumenti_complessi_manovale
     foreign key (IDManovale)
     references DIPENDENTI (IDDipendente);

alter table PRODOTTI add constraint FKmagazzini_prodotti
     foreign key (IDStruttura, IDMagazzino)
     references MAGAZZINI (IDStruttura, IDMagazzino);

alter table RICERCATORI add constraint FKricercatori_università
     foreign key (NomeUniversità)
     references UNIVERSITÀ  (Nome);

alter table SERRE add constraint FKclimi_serre
     foreign key (IDClima)
     references CLIMI (IDClima);

alter table SERRE add constraint FKstrutture_serre
     foreign key (IDStruttura)
     references STRUTTURE (IDStruttura);

alter table SERRE_INCUBAZIONE add constraint FKstrutture_serre_incubazione
     foreign key (IDStruttura)
     references STRUTTURE (IDStruttura);

alter table STRUMENTI_COMPLESSI add constraint FKmagazzini_strumenti_complessi
     foreign key (IDStruttura, IDMagazzino)
     references MAGAZZINI (IDStruttura, IDMagazzino);

alter table STRUMENTI_COMPLESSI_UTILIZZATI add constraint FKstrumenti_complessi_strumenti_complessi_utilizzati
     foreign key (IDStruttura, IDMagazzino, IDStrumentoComplesso)
     references STRUMENTI_COMPLESSI (IDStruttura, IDMagazzino, IDStrumentoComplesso);

alter table STRUMENTI_COMPLESSI_UTILIZZATI add constraint FKstrumenti_complessi_utilizzati_lavori_effettuati
     foreign key (IDLavoro, IDLavoroEffettuato)
     references LAVORI_EFFETTUATI (IDLavoro, IDLavoroEffettuato);

alter table STRUTTURE add constraint FKdirettori_strutture
     foreign key (IDDirettore)
     references DIPENDENTI (IDDipendente);

alter table SUPERVISIONI add constraint FKsupervisori_supervisioni
     foreign key (IDSupervisore)
     references DIPENDENTI (IDDipendente);

alter table SUPERVISIONI add constraint FKserre_supervisioni
     foreign key (IDStruttura, IDSerra)
     references SERRE (IDStruttura, IDSerra);

alter table UTENSILI add constraint FKmagazzini_utensili
     foreign key (IDStruttura, IDMagazzino)
     references MAGAZZINI (IDStruttura, IDMagazzino);

alter table VIAGGI_ISTRUZIONE add constraint FKguide_viaggi_istruzione
     foreign key (IDGuida)
     references DIPENDENTI (IDDipendente);

alter table VISITE add constraint FKvisite_serre
     foreign key (IDStruttura, IDSerra)
     references SERRE (IDStruttura, IDSerra);

alter table VISITE add constraint FKviaggi_istruzione_visite
     foreign key (IDGuida, IDViaggio)
     references VIAGGI_ISTRUZIONE (IDGuida, IDViaggio);
