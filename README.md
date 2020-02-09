# HotelApi

This is a testing exercise project.
ASP.NET Core API with one controller and one method, which takes two parameters: hotelId and language (defaults to "en", can be any of following list: "ru", "en", "fr", "zh", "hr", "ca", "de", "it", "es", "sl", "ja", "pl", "pt-br").

This method gets info from third party API, processes it, then adds additional info from a database. Resulting info is then returned as JSON.

Usage: GET /hotelinfo?hotelId=(int)&language=(string)
