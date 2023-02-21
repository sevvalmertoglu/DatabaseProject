CREATE TABLE STOK(
Stok_No INT NOT NULL,
Giris_Tarihi DATE NOT NULL,
Urun_Sayisi INT NOT NULL,
CONSTRAINT PK_Stok_No PRIMARY KEY (Stok_No)
);


CREATE TABLE URUN (
    Urun_ID INT NOT NULL,
    WVA_NO INT NOT NULL,
    OEM_NO INT NOT NULL,
    Kullanýlan_arac NVARCHAR(50) NOT NULL,
    Stok_No INT NOT NULL,
    Firma_ID INT NOT NULL,
    Fiyat SMALLMONEY NOT NULL,
    Kategori_ID INT NOT NULL,
    CONSTRAINT PK_Urun_ID PRIMARY KEY (Urun_ID)
);

CREATE TABLE KATEGORI(
    Kategori_ID INT NOT NULL,
    Kategori_Adi NVARCHAR(50) NOT NULL,
    CONSTRAINT PK_Kategori_ID PRIMARY KEY (Kategori_ID)
);


CREATE TABLE SIPARIS_DETAY(
    Siparis_Detay_ID INT NOT NULL,
    Urun_ID INT NOT NULL,
    Adet INT NOT NULL,
    Sehir_Kodu INT NOT NULL,
    CONSTRAINT PK_Siparis_Detay_ID PRIMARY KEY (Siparis_Detay_ID)
);



CREATE TABLE SEHIR(
    Sehir_Kodu INT NOT NULL,
    Sehir_Adi NVARCHAR(30) NOT NULL,
    CONSTRAINT PK_Sehir_Kodu PRIMARY KEY (Sehir_Kodu)
);

CREATE TABLE FIRMA(
    Firma_ID INT NOT NULL,
    Firma_Adi NVARCHAR(100) NOT NULL,
    Adres NVARCHAR(100) NOT NULL,
    Tel_NO NVARCHAR(20) NOT NULL,
    Fax NVARCHAR(20) NOT NULL,
    ePosta NVARCHAR(50) NOT NULL,
    CONSTRAINT PK_Firma_ID PRIMARY KEY (Firma_ID)
);

CREATE TABLE SIPARIS(
    Siparis_ID INT NOT NULL,
    Tarih DATE NOT NULL,
    Musteri_ID INT NOT NULL,
	Siparis_Detay_ID INT NOT NULL,
    CONSTRAINT PK_Siparis_ID PRIMARY KEY (Siparis_ID)
);

CREATE TABLE MUSTERI(
    Musteri_ID INT NOT NULL,
    Ad  nvarchar(50) NOT NULL,
    Soyad  nvarchar(100) NOT NULL,
    Ev_Tel VARCHAR(50),
    Is_Tel VARCHAR(50),
    Cep_Tel VARCHAR(50) NOT NULL,
    ePosta  nvarchar(50) NOT NULL,
    Adres  nvarchar(100) NOT NULL,
    CONSTRAINT PK_Musteri_ID PRIMARY KEY (Musteri_ID)
);



CREATE TABLE ODEME(
    Fatura_No VARCHAR(50) NOT NULL,
    Musteri_ID INT NOT NULL,
    Odeme_Tarihi DATE,
    Tutar SMALLMONEY NOT NULL,
    CONSTRAINT PK_Fatura_No PRIMARY KEY (Fatura_No)
);