# CustomDeathMessages
Sets custom death messages for each specific role that died, you can add or remove roles by deleting them or adding them, but make sure you get the format correct!

Open the .config file with a text editor and scroll down until you find the "CustomDeathMessages" section. This is where you will add your custom death messages.

The first thing you should do is to add the allowed classes and death reasons. These are the only classes and death reasons that the plugin will recognize, so make sure to only use the ones that are allowed.

To add a class or death reason, you should write it in the following format:


    ClassName:
      DeathReason:
      
For example, if you want to add a custom death message for ClassD when they die from a gunshot, you should write:

ClassD:
  AK: You have been shot!
  
You can add as many death reasons and classes as you want, just make sure to follow the same format. If you dont specify a reason or a entire role, the actual death reason will show.

The allowed death reasons so far are as follows (you can copy and paste these for anyone you want): 

      Tesla: 
      Scp173: 
      Scp049: 
      Scp0492: 
      Scp096: 
      Scp106: 
      Scp939: 
      Falldown: 
      Fsp9: 
      Hypothermia: 
      Jailbird: 
      Logicer: 
      MicroHid: 
      ParticleDisruptor: 
      PocketDimension: 
      Poison: 
      Recontainment: 
      Revolver: 
      SeveredHands: 
      Shotgun: 
      AK: 
      Asphyxiation: 
      Bleeding: 
      CardiacArrest: 
      Com15: 
      Com18: 
      Com45: 
      Crossvec: 
      E11Sr: 
      Explosion: 

And the allowed classes that are allowed are : 

    ClassD:
    NtfCaptain: 
    NtfPrivate: 
    NtfSergeant: 
    NtfSpecialist: 
    FacilityGuard: 
    Scientist: 
    ChaosConscript: 
    ChaosMarauder: 
    ChaosRepressor: 
    Scp049: 
    Scp0492: 
    Scp096: 
    Scp106:
    Scp173: 
    Scp939: 
