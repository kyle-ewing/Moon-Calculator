$(document).ready(function() {
    var jitaPrice;
    var unrefinedValue;
    var refinedValue;
    const m3Month = 13440000;

    console.log(scan);

    //console.log(scan.moonInfo["Balle III - Moon 8"].oreInfo);

    for(var moonInfo in scan) {
        //console.log(key + " : " + scan[key]);
        for(var ore in scan[moonInfo]) {
            var oreInfo = scan[moonInfo][ore];
            for(trash in oreInfo) {
                var realOreInfo = oreInfo[trash];
                for(oreType in realOreInfo) {
                    refinedValue = 0;
                    var OreID = itemID(oreType);
                    var oreAmount = m3Month*realOreInfo[oreType] / m3PerUnit(oreType);
                    console.log(oreAmount);
                    //console.log(mineralsPerBatch(oreType));

                    $.ajax({
                        url : "https://market.fuzzwork.co.uk/aggregates/?region=10000002&types=" + OreID,
                        type : "get",
                        async : false,
                        success : function(data) {
                            jitaPrice = data[OreID].buy.percentile;

                            if(jitaPrice == 0) {
                                jitaPrice = data[OreID].sell.percentile;
                            }

                            unrefinedValue = oreAmount * jitaPrice;
                            unrefinedValue = unrefinedValue.toFixed(2);
                            unrefinedValue = unrefinedValue.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
                            document.getElementById(oreType + " " + realOreInfo[oreType] + " " + "Raw").innerHTML = unrefinedValue;
                        }
                    }); 
                    var mineralBatch = mineralsPerBatch(oreType);
                    for(mineral in mineralBatch) {
                        //console.log(mineralBatch[mineral]);
                        var batches = oreAmount/100;
                       // console.log(mineral + " ==== " +oreType);
                        var mineralID = itemID(mineral);
                        $.ajax({
                            url : "https://market.fuzzwork.co.uk/aggregates/?region=10000002&types=" + mineralID,
                            type : "get",
                            async : false,
                            success : function(data) {
                                jitaPrice = data[mineralID].buy.percentile;
                                refinedValue += batches*mineralBatch[mineral]*jitaPrice;
                            }
                        });
                    }
                    refinedValue = refinedValue.toFixed(2);
                    refinedValue = refinedValue.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
                    document.getElementById(oreType + " " + realOreInfo[oreType] + " " + "Refined").innerHTML = refinedValue;
                }
            }
        }
    }
});