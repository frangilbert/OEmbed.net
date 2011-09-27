# oEmbed for .net
Written in C#, this should make using oEmbed as simple as possible. Any feedback welcome.
Look at oEmbed.com for details of the standard.

## Requirements
You'll need .NET Framework 3.5 or later to use the precompiled binaries. To build the code, you'll need Visual Studio 2010.

## Instructions
A simple way of using this library would be as follows. Download the library and add to your project. Where you want to use the library add: using OEmbed.Net;

To get a feed from Flickr, for example, you'd use:  
`var photo = new Consumer<Photo>();`
`photo.GetObject("http://flickr.com/services/oembed?url=http%3A//flickr.com/photos/bees/2362225867/");`  

or for Youtube try:  
`var video = new Consumer<Video>();`
`video.GetObject("http://www.youtube.com/oembed?url=http%3A//www.youtube.com/watch?v%3D-UUx10KOWIE&format=json");`  

## Questions
Feel free to ask any questions on the wiki