# QR-generator_v1

````md
# C# QR Console Generator

C# yordamida konsolda QR-kod yaratish uchun oddiy va yengil CLI dasturi.  
Loyiha `QRCoder` kutubxonasidan foydalanadi.

## O‘rnatish

Loyihaga kerakli kutubxonani o‘rnating:

```bash
dotnet add package QRCoder
````

## Ishlatish

### Oddiy QR yaratish

```bash
dotnet run -- "Salom dunyo" qr.png
```

### Fayldan o‘qish

```bash
dotnet run -- -f text.txt qr.png
```

## Parametrlar

* `data` — matn yoki URL
* `-f <file>` — QR matnini fayldan o‘qish
* `output.png` — chiqqan QR fayl nomi (default: `qr.png`)

## Natija

Dastur kiritilgan matn asosida PNG formatidagi QR-kodni yaratadi va ko‘rsatilgan faylga saqlaydi.


Agar xohlasangiz README uchun **rasmli demo**, **badge**, yoki **ASCII preview misollari** ham qo‘shib beraman.
```
