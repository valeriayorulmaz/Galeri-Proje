--þubeler ile araçlar tablosunu birleþtir þub adý, marka, kategori, fiyat, adet göster
alter proc S1
as begin
select Ad, Marka, Model, Fiyat,Adet from Subeler s join Araclar a on s.SubeNo=a.SubeNo 
end

--Müþterileri bakiyelerini küçükten büyüðe sýrala
create proc S2
as begin
select AdSoyad,Bakiye from Musteri order by Bakiye asc
end

--þubelerin cirolarýnýn ortalamasý
create proc S3 
as begin 
select avg(Ciro) as 'Þubelerin Ciro Ortalamasý' from Subeler
end

--müþterilerin aldýðý araçlar
alter proc S4
as begin
select MusteriNo,AdSoyad, Marka, Model, Fiyat from Araclar a join Musteri m on a.MüsteriNo= m.MusteriNo order by AdSoyad asc
end

alter proc S5
as begin
select SubeNo,Ad,AdSoyad, MusteriNo, Bakiye from Subeler join Musteri on Subeler.Ad = Musteri.Adres order by SubeNo asc
end