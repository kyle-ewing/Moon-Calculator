$(document).ready(function() {
    var jitaPrice;
    var unrefinedValue;
    var refinedValue;
    console.log(scan);
    const m3Month = 13440000;

    //console.log(scan.moonInfo["Balle III - Moon 8"].oreInfo);

    for(var moonInfo in scan) {
        //console.log(key + " : " + scan[key]);
        for(var ore in scan[moonInfo]) {
            console.log(ore + " : " + scan[key][ore]);
            var oreInfo = scan[moonInfo][ore];
            for(trash in oreInfo) {
                var realOreInfo = oreInfo[trash];
                for(oreType in realOreInfo) {
                    console.log(oreType + ": " + realOreInfo[oreType]);
                    var OreID = itemID(oreType);
                    //console.log(itemID(oreType));
                    console.log(oreType);
                    console.log(mineralsPerBatch(oreType));

                    $.ajax({
                        url : "https://market.fuzzwork.co.uk/aggregates/?region=10000002&types=" + OreID,
                        type : "get",
                        async : false,
                        success : function(data) {
                            jitaPrice = data[OreID].sell.weightedAverage;

                            if(jitaPrice == 0) {
                                jitaPrice = data[OreID].buy.percentile;
                            }

                            unrefinedValue = ((m3Month*realOreInfo[oreType]) / m3PerUnit(oreType)) * jitaPrice;
                            unrefinedValue = unrefinedValue.toFixed(2);
                            document.getElementById(oreType + " " + realOreInfo[oreType]).innerHTML = unrefinedValue;
                        }
                    }); 
                }
            }
        }
    }
});

