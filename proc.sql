--�ubeler ile ara�lar tablosunu birle�tir �ub ad�, marka, kategori, fiyat, adet g�ster
alter proc S1
as begin
select Ad, Marka, Model, Fiyat,Adet from Subeler s join Araclar a on s.SubeNo=a.SubeNo 
end

--M��terileri bakiyelerini k���kten b�y��e s�rala
create proc S2
as begin
select AdSoyad,Bakiye from Musteri order by Bakiye asc
end

--�ubelerin cirolar�n�n ortalamas�
create proc S3 
as begin 
select avg(Ciro) as '�ubelerin Ciro Ortalamas�' from Subeler
end

--m��terilerin ald��� ara�lar
alter proc S4
as begin
select MusteriNo,AdSoyad, Marka, Model, Fiyat from Araclar a join Musteri m on a.M�steriNo= m.MusteriNo order by AdSoyad asc
end

alter proc S5
as begin
select SubeNo,Ad,AdSoyad, MusteriNo, Bakiye from Subeler join Musteri on Subeler.Ad = Musteri.Adres order by SubeNo asc
end