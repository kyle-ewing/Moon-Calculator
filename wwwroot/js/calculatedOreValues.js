$(document).ready(function() {
    var jitaPrice;
    var unrefinedValue;
    console.log(scan);
    const m3Month = 13440000;

    //console.log(scan.moonInfo["Balle III - Moon 8"].oreInfo);

    for(var moonInfo in scan) {
        //console.log(key + " : " + scan[key]);
        for(var ore in scan[moonInfo]) {
            //console.log(ore + " : " + scan[key][ore]);
            var oreInfo = scan[moonInfo][ore];
            for(trash in oreInfo) {
                var realOreInfo = oreInfo[trash];
                for(oreType in realOreInfo) {
                    //console.log(oreType + ": " + realOreInfo[oreType]);
                    var id = itemID(oreType);
                    //console.log(itemID(oreType));

                    $.ajax({
                        url : "https://market.fuzzwork.co.uk/aggregates/?region=10000002&types=" + id,
                        type : "get",
                        async : false,
                        success : function(data) {
                            jitaPrice = data[id].sell.weightedAverage;
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

