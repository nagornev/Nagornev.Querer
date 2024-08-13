# [Nagornev.Querer](https://github.com/nagornev/Nagornev.Querer)

## Information

This library is the basis for creating isolated querers.

## Installation

Install the current version with __[dotnet](https://dotnet.microsoft.com/ru-ru/)__:
```C#
dotnet add package Nagornev.Querer
```

## Usage

This library has 3 main components:

 - ```QuererClient<TRequestType, TResponseType>``` - required to send a request and handle a response;
 - ```QuererRequestCompiler<TRequestType>```, ```QuererResponseHandler<TResponseType>``` - required to create a request and handle a response;
 - ```QuererRequestsCompiler<TRequestType>```, ```QuererResponsesHandler<TResponseType>``` - required to create the requests and handle the responses;

You need to implement each of them to create an isolated querer.

### Sample

You can see how to use this in a concrete [sample](https://github.com/nagornev/Nagornev.Querer.Http).
