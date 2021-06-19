-- STRUTTURE
INSERT INTO [dbo].[STRUTTURE] ([IDStruttura], [Nome], [Provincia], [CAP], [Via], [NumeroCivico], [Telefono], [DataInizioGestione], [IDDirettore]) VALUES (1, N'La Bolognese', N'BO', N'40059', N'Leonardo da Vinci', N'12', N'3657534615', N'2019-05-14 00:00:00', NULL)
INSERT INTO [dbo].[STRUTTURE] ([IDStruttura], [Nome], [Provincia], [CAP], [Via], [NumeroCivico], [Telefono], [DataInizioGestione], [IDDirettore]) VALUES (2, N'Zona Verde', N'MI', N'35645', N'Fiori Rigogliosi', N'25', N'0745365741', N'2021-01-01 00:00:00', NULL)

-- UNIVERSITA'
INSERT INTO [dbo].[UNIVERSITÀ] ([Nome], [Telefono], [FAX], [Mail], [Provincia], [CAP], [Via], [NumeroCivico]) VALUES (N'UNIBO', N'0512099111', N'051209911', N'bologna@unibo.it', N'BO', N'40126', N'Zamboni', N'33')
INSERT INTO [dbo].[UNIVERSITÀ] ([Nome], [Telefono], [FAX], [Mail], [Provincia], [CAP], [Via], [NumeroCivico]) VALUES (N'UNIPI', N'0502212111', N'05040834', N'protocollo@pec.unipi.it', N'PI', N'56126', N'Lungarno Pacinotti', N'43')

-- GARAGE
INSERT INTO [dbo].[GARAGE] ([IDStruttura], [IDGarage], [Nome], [Dimensione], [ParcheggiTotali], [ParcheggiLiberi]) VALUES (1, 1, N'GaragePrimo', 250, 4, 2)

-- MACCHINARI
INSERT INTO [dbo].[MACCHINARI] ([NumeroTelaio], [Marca], [Modello], [Targa], [DataRevisione], [LivelloCarburante], [IDStruttura], [IDGarage]) VALUES (N'DA8FGN7EBA2000450', N'Lamborghini', N'Spire', N'JK85146', N'2021-06-05 00:00:00', 40, 1, 1)
INSERT INTO [dbo].[MACCHINARI] ([NumeroTelaio], [Marca], [Modello], [Targa], [DataRevisione], [LivelloCarburante], [IDStruttura], [IDGarage]) VALUES (N'YV1XZA6BCJ2000450', N'Lamborghini', N'SPARK VRT', N'AB12345', N'2020-06-10 00:00:00', 85, 1, 1)

-- PIANTE
INSERT INTO [dbo].[PIANTE] ([IDPianta], [Razza], [Varietà], [UnitàOccupate]) VALUES (1, N'Begonia', N'Coccinea', 2)
INSERT INTO [dbo].[PIANTE] ([IDPianta], [Razza], [Varietà], [UnitàOccupate]) VALUES (2, N'Rosa', N'Damascena', 4)

-- DIPENDENTI
INSERT INTO [dbo].[DIPENDENTI] ([IDDipendente], [CF], [Nome], [Cognome], [Provincia], [CAP], [Via], [NumeroCivico], [Telefono], [Mail], [Ruolo], [Stipendio], [CV], [IDStruttura], [AbilitazioneProdottiChimici]) VALUES (1, N'NPLGTB61B42E791L', N'Marco', N'Renati', N'BO', N'56845', N'San Lorenzo', N'41', N'3218524679', N'marco@gmail.com', N'gestore_esperimenti', 1500, N'Si è laureato in biologia con 110/110 con lode', 1, NULL)
INSERT INTO [dbo].[DIPENDENTI] ([IDDipendente], [CF], [Nome], [Cognome], [Provincia], [CAP], [Via], [NumeroCivico], [Telefono], [Mail], [Ruolo], [Stipendio], [CV], [IDStruttura], [AbilitazioneProdottiChimici]) VALUES (2, N'MNSYGL80R05E381W', N'Giovanni', N'Piervalli', N'BO', N'40217', N'Rinaldo Coppoli', N'24', N'3941674589', N'giovanni.pp@gmail.com', N'direttore', 2000, N'Ha sempre lavorato per DataGreenHouse', 1, NULL)
INSERT INTO [dbo].[DIPENDENTI] ([IDDipendente], [CF], [Nome], [Cognome], [Provincia], [CAP], [Via], [NumeroCivico], [Telefono], [Mail], [Ruolo], [Stipendio], [CV], [IDStruttura], [AbilitazioneProdottiChimici]) VALUES (3, N'VMOMVF75L19A071M', N'Roberto', N'Guidone', N'MI', N'25468', N'Giacomo Totari', N'45', N'3641622648', N'robi.guido@gmail.com', N'guida', 1200, N'Ha lavorato al giardino di Boboli', 1, NULL)
INSERT INTO [dbo].[DIPENDENTI] ([IDDipendente], [CF], [Nome], [Cognome], [Provincia], [CAP], [Via], [NumeroCivico], [Telefono], [Mail], [Ruolo], [Stipendio], [CV], [IDStruttura], [AbilitazioneProdottiChimici]) VALUES (4, N'RNTMSM80A20F205N', N'Massimo', N'Renati', N'MI', N'74526', N'Pisatrello Milo', N'24', N'3156731684', N'massimo.lavoro@gmail.com', N'direttore', 2100, N'Laureato a scienze politiche', 2, NULL)

-- RICERCATORI
INSERT INTO [dbo].[RICERCATORI] ([IDRicercatore], [CF], [Nome], [Cognome], [Provincia], [CAP], [Via], [NumeroCivico], [Telefono], [Mail], [Competenza], [Dipartimento], [NomeUniversità]) VALUES (1, N'NTGBDL61E05L199W', N'Mario', N'Rossi', N'PU', N'61032', N'Gentile da Fabriano', N'27', N'3455684956', N'mario.rossi.25@unibo.it', N'Biologia', N'Scienze', N'UNIBO')
INSERT INTO [dbo].[RICERCATORI] ([IDRicercatore], [CF], [Nome], [Cognome], [Provincia], [CAP], [Via], [NumeroCivico], [Telefono], [Mail], [Competenza], [Dipartimento], [NomeUniversità]) VALUES (2, N'JTVGDP50P43C047Z', N'Ludovico', N'Ricercatori', N'BO', N'40257', N'Ludovico Einaudi', N'12', N'3415829137', N'ludovico.rr@gmail.com', N'Geologia', N'Scienze', N'UNIBO')
INSERT INTO [dbo].[RICERCATORI] ([IDRicercatore], [CF], [Nome], [Cognome], [Provincia], [CAP], [Via], [NumeroCivico], [Telefono], [Mail], [Competenza], [Dipartimento], [NomeUniversità]) VALUES (3, N'KLZZNR54P11B419V
', N'Giulio', N'Cesare', N'RO', N'20451', N'degli Imperatori', N'17', N'3657416497', N'giulio.cesare@senato.it', N'Politica', N'Gallia', N'UNIBO')

-- ESPERIMENTI
INSERT INTO [dbo].[ESPERIMENTI] ([IDEsperimento], [DataInizio], [DataFine], [DataApprovazione], [Descrizione], [IDAutorizzante], [IDRicercatoreCapo]) VALUES (1, N'2019-06-10 00:00:00', N'2020-05-31 00:00:00', N'2019-05-20 00:00:00', N'Testare le begonie nel clima tropicale', 1, 1)
INSERT INTO [dbo].[ESPERIMENTI] ([IDEsperimento], [DataInizio], [DataFine], [DataApprovazione], [Descrizione], [IDAutorizzante], [IDRicercatoreCapo]) VALUES (2, N'2019-07-01 00:00:00', N'2020-02-15 00:00:00', N'2019-06-15 00:00:00', N'Fioritura rose in clima artico', 1, 1)
INSERT INTO [dbo].[ESPERIMENTI] ([IDEsperimento], [DataInizio], [DataFine], [DataApprovazione], [Descrizione], [IDAutorizzante], [IDRicercatoreCapo]) VALUES (3, N'2019-07-05 00:00:00', N'2020-07-05 00:00:00', N'2019-06-21 00:00:00', N'Rose in clima tropicale', 1, 2)
INSERT INTO [dbo].[ESPERIMENTI] ([IDEsperimento], [DataInizio], [DataFine], [DataApprovazione], [Descrizione], [IDAutorizzante], [IDRicercatoreCapo]) VALUES (4, N'2019-06-25 00:00:00', N'2019-12-27 00:00:00', N'2019-06-01 00:00:00', N'Begonie con clima africano', 1, 3)

-- COLLABORAZIONI
INSERT INTO [dbo].[COLLABORAZIONI] ([IDEsperimento], [IDRicercatore]) VALUES (2, 3)
INSERT INTO [dbo].[COLLABORAZIONI] ([IDEsperimento], [IDRicercatore]) VALUES (3, 1)

-- CLIMI
INSERT INTO [dbo].[CLIMI] ([IDClima], [Nome], [Descrizione], [Luce], [OreLuce], [Umidità], [Temperatura]) VALUES (1, N'Tropicale', N'Questo clima è tropicale', N'naturale', 16, 80, 28)
INSERT INTO [dbo].[CLIMI] ([IDClima], [Nome], [Descrizione], [Luce], [OreLuce], [Umidità], [Temperatura]) VALUES (2, N'Artico', N'Rappresenta il clima tipo dell''Artide', N'naturale', 24, 30, -30)
INSERT INTO [dbo].[CLIMI] ([IDClima], [Nome], [Descrizione], [Luce], [OreLuce], [Umidità], [Temperatura]) VALUES (3, N'Equatoriale', N'Clima equatoriale tipico del Sud America', N'naturale', 12, 70, 27)

-- SERRE
INSERT INTO [dbo].[SERRE] ([IDStruttura], [IDSerra], [Area], [NumeroUnitàMassime], [NumeroUnitàOccupate], [IDClima]) VALUES (1, 1, 1000, 2000, 0, 1)
INSERT INTO [dbo].[SERRE] ([IDStruttura], [IDSerra], [Area], [NumeroUnitàMassime], [NumeroUnitàOccupate], [IDClima]) VALUES (1, 2, 1000, 2000, 0, 2)
INSERT INTO [dbo].[SERRE] ([IDStruttura], [IDSerra], [Area], [NumeroUnitàMassime], [NumeroUnitàOccupate], [IDClima]) VALUES (1, 3, 1000, 2000, 0, 3)
INSERT INTO [dbo].[SERRE] ([IDStruttura], [IDSerra], [Area], [NumeroUnitàMassime], [NumeroUnitàOccupate], [IDClima]) VALUES (2, 1, 1500, 3000, 2500, 1)

-- CLUSTER
INSERT INTO [dbo].[CLUSTER] ([IDStruttura], [IDSerra], [IDCluster], [Dimensione], [ComposizioneNPKTerreno]) VALUES (1, 1, 1, N'piccolo', N'20-10-10')
INSERT INTO [dbo].[CLUSTER] ([IDStruttura], [IDSerra], [IDCluster], [Dimensione], [ComposizioneNPKTerreno]) VALUES (1, 1, 2, N'piccolo', N'20-10-10')
INSERT INTO [dbo].[CLUSTER] ([IDStruttura], [IDSerra], [IDCluster], [Dimensione], [ComposizioneNPKTerreno]) VALUES (1, 1, 3, N'medio', N'20-20-20')
INSERT INTO [dbo].[CLUSTER] ([IDStruttura], [IDSerra], [IDCluster], [Dimensione], [ComposizioneNPKTerreno]) VALUES (1, 1, 4, N'medio', N'30-10-10')
INSERT INTO [dbo].[CLUSTER] ([IDStruttura], [IDSerra], [IDCluster], [Dimensione], [ComposizioneNPKTerreno]) VALUES (1, 2, 1, N'piccolo', N'10-10-10')
INSERT INTO [dbo].[CLUSTER] ([IDStruttura], [IDSerra], [IDCluster], [Dimensione], [ComposizioneNPKTerreno]) VALUES (2, 1, 1, N'piccolo', N'20-20-20')

-- CLUSTER_PIANTE
INSERT INTO [dbo].[CLUSTER_PIANTE] ([IDClusterPiante], [DataInizio], [DataFine], [DataTrapianto], [DataEspianto], [NumeroPianteIniziali], [NumeroPianteMorte], [TrattamentoBiologico], [DataSmaltimento], [IDStruttura], [IDSerra], [IDCluster], [IDEsperimento], [IDPianta]) VALUES (1, N'2019-06-10 00:00:00', N'2020-05-31 00:00:00', N'2019-06-20 00:00:00', N'2020-05-15 00:00:00', 28, 5, N'biologico', N'2020-05-20 00:00:00', 1, 1, 1, 1, 1)
INSERT INTO [dbo].[CLUSTER_PIANTE] ([IDClusterPiante], [DataInizio], [DataFine], [DataTrapianto], [DataEspianto], [NumeroPianteIniziali], [NumeroPianteMorte], [TrattamentoBiologico], [DataSmaltimento], [IDStruttura], [IDSerra], [IDCluster], [IDEsperimento], [IDPianta]) VALUES (2, N'2019-06-10 00:00:00', N'2020-05-31 00:00:00', N'2019-06-20 00:00:00', N'2020-05-15 00:00:00', 28, 10, N'biologico', N'2020-05-21 00:00:00', 1, 1, 2, 1, 1)
INSERT INTO [dbo].[CLUSTER_PIANTE] ([IDClusterPiante], [DataInizio], [DataFine], [DataTrapianto], [DataEspianto], [NumeroPianteIniziali], [NumeroPianteMorte], [TrattamentoBiologico], [DataSmaltimento], [IDStruttura], [IDSerra], [IDCluster], [IDEsperimento], [IDPianta]) VALUES (3, N'2019-07-01 00:00:00', N'2020-02-15 00:00:00', N'2019-07-11 00:00:00', N'2020-02-01 00:00:00', 14, 11, N'tradizionale', N'2020-02-05 00:00:00', 1, 2, 1, 2, 2)
INSERT INTO [dbo].[CLUSTER_PIANTE] ([IDClusterPiante], [DataInizio], [DataFine], [DataTrapianto], [DataEspianto], [NumeroPianteIniziali], [NumeroPianteMorte], [TrattamentoBiologico], [DataSmaltimento], [IDStruttura], [IDSerra], [IDCluster], [IDEsperimento], [IDPianta]) VALUES (4, N'2019-07-05 00:00:00', N'2020-07-05 00:00:00', N'2019-07-15 00:00:00', N'2020-06-20 00:00:00', 28, 0, N'biologico', N'2020-06-30 00:00:00', 1, 1, 3, 3, 2)

-- ANNOTAZIONI
INSERT INTO [dbo].[ANNOTAZIONI] ([IDEsperimento], [NumeroAnnotazione], [DataOra], [Testo], [IDRicercatore]) VALUES (2, 1, N'2019-07-12 13:27:56', N'Abbiamo registrato la prima morte, era una rosa posizionata nella zona destra del cluster', 1)
