//ID of ore and minerals when calling EVE's API
function itemID(typeName) {
    const typeIDs = {
        "Atmospheric Gases" : 16634,
        "Bitumens" : 45492,
        "Brilliant Gneiss" : 46679,
        "Cadmium" : 16643,
        "Caesium" : 16647,
        "Chromite" : 45501,
        "Chromium" : 16641,
        "Cinnabar" : 45506,
        "Cobalt" : 16640,
        "Cobaltite" : 45494,
        "Coesite" : 45493,
        "Cubic Bistot" : 46676,
        "Dazzling Spodumain" : 46688,
        "Dysprosium" : 16650,
        "Euxenite" : 45495,
        "Evaporite Deposits" : 16635,
        "Flawless Arkonor" : 46678,
        "Glossy Scordite" : 46687,
        "Hafnium" : 16648,
        "Hydrocarbons" : 16633,
        "Immaculate Jaspet" : 46682,
        "Isogen" : 37,
        "Jet Ochre" : 46675,
        "Loparite" : 45512,
        "Lustrous Hedbergite" : 46680,
        "Megacyte" : 40,
        "Mercury" : 16646,
        "Mexallon" : 36,
        "Nocxium" : 38,
        "Monazite" : 45511,
        "Neodymium" : 16651,
        "Opulent Pyroxeres" : 46686,
        "Otavite" : 45498,
        "Platinoid Omber" : 46684,
        "Platinum" : 16644,
        "Pellucid Crokite" : 46677,
        "Pollucite" : 45504,
        "Promethium" : 16652,
        "Pyerite" : 35,
        "Resplendant Kernite" : 46683,
        "Scandium" : 16639,
        "Scheelite" : 45497,
        "Scintillating Hemorphite" : 46681,
        "Silicates" : 16636,
        "Sparkling Plagioclase" : 46685,
        "Sperrylite" : 45499,
        "Stable Veldspar" : 46689,
        "Sylvite" : 45491,
        "Technetium" : 16649,
        "Thulium" : 16653,
        "Titanite" : 45496,
        "Titanium" : 16638,
        "Tritanium" : 34,
        "Tungsten" : 16637,
        "Vanadinite" : 45500,
        "Vanadium" : 16642,
        "Xenotime" : 45510,
        "Ytterbite" : 45513,
        "Zeolites" : 45490,
        "Zircon" : 45503,
        "Zydrine" : 39                
    }

    if(!typeIDs.hasOwnProperty(typeName)) {
        console.log("Misspelled Key Name"); 
    }

    return typeIDs[typeName];
}

//Weight of each individual unit of ore
function m3PerUnit(ore) {
    const orem3 = {
        "Bitumens" : 10,
        "Brilliant Gneiss" : 5,
        "Chromite" : 10,
        "Cinnabar" : 10,
        "Cobaltite" : 10,
        "Coesite" : 10,
        "Cubic Bistot" : 16,
        "Dazzling Spodumain" : 16,
        "Euxenite" : 10,
        "Flawless Arkonor" : 16,
        "Glossy Scordite" : 0.15,
        "Immaculate Jaspet" : 2,
        "Jet Ochre" : 8,
        "Loparite" : 10,
        "Lustrous Hedbergite" : 3,
        "Monazite" : 10,
        "Opulent Pyroxeres" : 0.30,
        "Otavite" : 10,
        "Platinoid Omber" : 0.60,
        "Pellucid Crokite" : 16,
        "Pollucite" : 10,
        "Resplendant Kernite" : 1.20,
        "Scheelite" : 10,
        "Scintillating Hemorphite" : 3,
        "Sparkling Plagioclase" : 0.35,
        "Sperrylite" : 10,
        "Stable Veldspar" : 0.10,
        "Sylvite" : 10,
        "Titanite" : 10,
        "Vanadinite" : 10,
        "Xenotime" : 10,
        "Ytterbite" : 10,
        "Zeolites" : 10,
        "Zircon" : 10     
    }
    return orem3[ore];
}

//Minerals per 100 units of ore assuming 100% refining
function mineralsPerBatch(ore) {
    const batch = {
        "Bitumens" : {
            "Tritanium" : 6000,
            "Pyerite" : 6000,
            "Mexallon" : 400,
            "Hydrocarbons" : 65
        },
        "Brilliant Gneiss" : {
            "Pyerite" : 2530,
            "Mexallon" : 2760,
            "Isogen" : 345
        },
        "Chromite" : {
            "Pyerite" : 5000,
            "Mexallon" : 1250,
            "Isogen" : 50,
            "Hydrocarbons" : 10,
            "Chromium" : 40
        },
        "Cinnabar" : {
            "Mexallon" : 1500,
            "Isogen" : 750,
            "Megacyte" : 50,
            "Evaporite Deposits" : 15,
            "Tungsten" : 10,
            "Mercury" : 50
        },
        "Cobaltite" : {
            "Tritanium" : 7500,
            "Pyerite" : 10000,
            "Mexallon" : 500,
            "Cobalt" : 40
        },
        "Coesite" : {
            "Tritanium" : 6000,
            "Pyerite" : 2000,
            "Mexallon" : 400,
            "Silicates" : 66
        },
        "Cubic Bistot" : {
            "Pyerite" : 13800,
            "Zydrine" : 518,
            "Megacyte" : 115
        },
        "Dazzling Spodumain" : {
            "Tritanium" : 64400,
            "Pyerite" : 13858,
            "Mexallon" : 2415,
            "Isogen" : 518
        },
        "Euxenite" : {
            "Tritanium" : 10000,
            "Pyerite" : 7500,
            "Mexallon" : 500,
            "Scandium" : 40
        },
        "Flawless Arkonor" : {
            "Tritanium" : 25300,
            "Mexallon" : 2875,
            "Megacyte" : 368
        },
        "Glossy Scordite" : {
            "Tritanium" : 398,
            "Pyerite" : 199
        },
        "Immaculate Jaspet" : {
            "Mexallon" : 403,
            "Nocxium" : 86,
            "Zydrine" : 9
        },
        "Jet Ochre" : {
            "Tritanium" : 11500,
            "Isogen" : 1840,
            "Nocxium" : 138
        },
        "Loparite" : {
            "Nocxium" : 100,
            "Zydrine" : 200,
            "Megacyte" : 50,
            "Hydrocarbons" : 20,
            "Scandium" : 20,
            "Platinum" : 10,
            "Promethium" : 22
        },
        "Lustrous Hedbergite" : {
            "Pyerite" : 1150,
            "Isogen" : 230,
            "Nocxium" : 115,
            "Megacyte" : 22
        },
        "Monazite" : {
            "Nocxium" : 50,
            "Zydrine" : 150,
            "Megacyte" : 150,
            "Evaporite Deposits" : 20,
            "Tungsten" : 20,
            "Chromium" : 10,
            "Neodymium" : 22
        },
        "Opulent Pyroxeres" : {
            "Tritanium" : 404,
            "Pyerite" : 29,
            "Mexallon" : 58,
            "Zydrine" : 6
        },
        "Otavite" : {
            "Tritanium" : 5000,
            "Mexallon" : 1500,
            "Isogen" : 500,
            "Nocxium" : 50,
            "Atmospheric Gases" : 10,
            "Cadmium" : 40
        },
        "Platinoid Omber" : {
            "Tritanium" : 920,
            "Pyerite" : 115,
            "Isogen" : 98
        },
        "Pellucid Crokite" : {
            "Tritanium" : 24150,
            "Nocxium" : 874,
            "Megacyte" : 155
        },
        "Pollucite" : {
            "Mexallon" : 1250,
            "Isogen" : 1000,
            "Zydrine" : 50,
            "Hydrocarbons" : 15,
            "Scandium" : 10,
            "Caesium" : 50
        },
        "Resplendant Kernite" : {
            "Tritanium" : 154,
            "Mexallon" : 307,
            "Isogen" : 154
        },
        "Scheelite" : {
            "Tritanium" : 12500,
            "Pyerite" : 5000,
            "Mexallon" : 500,
            "Tungsten" : 40
        },
        "Scintillating Hemorphite" : {
            "Tritanium" : 2530,
            "Isogen" : 115,
            "Nocxium" : 138,
            "Zydrine" : 17
        },
        "Sparkling Plagioclase" : {
            "Tritanium" : 123,
            "Pyerite" : 245,
            "Mexallon" : 123
        },
        "Sperrylite" : {
            "Tritanium" : 5000,
            "Mexallon" : 1000,
            "Isogen" : 1000,
            "Zydrine" : 50,
            "Evaporite Deposits" : 10,
            "Platinum" : 40
        },
        "Stable Veldspar" : {
            "Tritanium" : 477
        },
        "Sylvite" : {
            "Tritanium" : 8000,
            "Pyerite" : 4000,
            "Mexallon" : 400,
            "Evaporite Deposits" : 65
        },
        "Titanite" : {
            "Tritanium" : 15000,
            "Pyerite" : 2500,
            "Mexallon" : 500,
            "Titanium" : 40
        },
        "Vanadinite" : {
            "Pyerite" : 5000,
            "Mexallon" : 750,
            "Isogen" : 1250,
            "Zydrine" : 50,
            "Silicates" : 10,
            "Vanadium" : 40
        },
        "Xenotime" : {
            "Nocxium" : 200,
            "Zydrine" : 100,
            "Megacyte" : 50,
            "Atmospheric Gases" : 20,
            "Cobalt" : 20,
            "Vanadium" : 10,
            "Dysprosium" : 22
        },
        "Ytterbite" : {
            "Nocxium" : 50,
            "Zydrine" : 100,
            "Megacyte" : 200,
            "Silicates" : 20,
            "Titanium" : 20,
            "Cadmium" : 10,
            "Thulium" : 22
        },
        "Zeolites" : {
            "Tritanium" : 4000,
            "Pyerite" : 8000,
            "Mexallon" : 400,
            "Atmospheric Gases" : 65
        },
        "Zircon" : {
            "Mexallon" : 1750,
            "Isogen" : 500,
            "Megacyte" : 50,
            "Silicates" : 15,
            "Titanium" : 10,
            "Hafnium" : 50
        } 
    }
    return batch[ore];
}