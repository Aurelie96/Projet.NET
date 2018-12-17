#------------------------------------------------------------
#        Script MySQL.
#------------------------------------------------------------


#------------------------------------------------------------
# Table: Niveaux
#------------------------------------------------------------

CREATE TABLE Niveaux(
        idNiveau  Int  Auto_increment  NOT NULL ,
        nomNiveau Varchar (255) NOT NULL
	,CONSTRAINT Niveaux_PK PRIMARY KEY (idNiveau)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Users
#------------------------------------------------------------

CREATE TABLE Users(
        idUser     Int  Auto_increment  NOT NULL ,
        nomUser    Varchar (255) NOT NULL ,
        prenomUser Varchar (255) NOT NULL ,
        loginuser  Varchar (255) NOT NULL ,
        mdpUser    Varchar (255) NOT NULL ,
        emailUser  Varchar (255) NOT NULL ,
        tuteurUser Bool NOT NULL ,
        eleveUser  Bool NOT NULL ,
        idNiveau   Int NOT NULL
	,CONSTRAINT Users_PK PRIMARY KEY (idUser)

	,CONSTRAINT Users_Niveaux_FK FOREIGN KEY (idNiveau) REFERENCES Niveaux(idNiveau)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Messages
#------------------------------------------------------------

CREATE TABLE Messages(
        idMessage         Int  Auto_increment  NOT NULL ,
        objetMessage      Varchar (255) NOT NULL ,
        texteMessage      Varchar (255) NOT NULL ,
        dateEnvoieMessage Date NOT NULL ,
        idUser            Int NOT NULL
	,CONSTRAINT Messages_PK PRIMARY KEY (idMessage)

	,CONSTRAINT Messages_Users_FK FOREIGN KEY (idUser) REFERENCES Users(idUser)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Matieres
#------------------------------------------------------------

CREATE TABLE Matieres(
        idMatiere  Int  Auto_increment  NOT NULL ,
        nomMatiere Varchar (255) NOT NULL
	,CONSTRAINT Matieres_PK PRIMARY KEY (idMatiere)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: composer
#------------------------------------------------------------

CREATE TABLE composer(
        idMatiere Int NOT NULL ,
        idNiveau  Int NOT NULL
	,CONSTRAINT composer_PK PRIMARY KEY (idMatiere,idNiveau)

	,CONSTRAINT composer_Matieres_FK FOREIGN KEY (idMatiere) REFERENCES Matieres(idMatiere)
	,CONSTRAINT composer_Niveaux0_FK FOREIGN KEY (idNiveau) REFERENCES Niveaux(idNiveau)
)ENGINE=InnoDB;
