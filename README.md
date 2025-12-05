# QR-generator_v1

# C# QR Console Generator

C# yordamida konsolda QR-kod yaratish uchun oddiy va yengil CLI dasturi.
Loyiha `QRCoder` kutubxonasidan foydalanadi.

## O‘rnatish

```bash
dotnet add package QRCoder
```

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
* `-f <file>` — matnni fayldan o‘qish
* `output.png` — saqlanadigan QR fayl nomi (default: `qr.png`)

## Natija

Dastur kiritilgan matndan PNG formatidagi QR-kod yaratadi va ko‘rsatilgan faylga saqlaydi.


