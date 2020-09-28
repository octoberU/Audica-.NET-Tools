# Audica .NET Tools
Multiple C# classes used for serializing and deserializing `.audica` files.  

### Example Usage

Reading metadata
```cs
var audica = new Audica(filepath);
Console.WriteLine(audica.desc.title);
```

Looping over cues
```cs
var audica = new Audica(filepath);
foreach (var cue in audica.expert.cues)
{
    Console.WriteLine(cue.tick);
}
```

Getting metadata without parsing the whole .audica file
```cs
Description desc = Audica.GetDescOnly(filepath);
Console.WriteLine(desc.title);
```

### To do:
* Serialization
* Reading tempo data
