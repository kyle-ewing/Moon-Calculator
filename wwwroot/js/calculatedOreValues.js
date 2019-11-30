$(document).ready(function() {
    var jitaPrice;
    var unrefinedValue;
    var refinedValue;
    var totalValue;

    //Total m3 of ore from a month long extraction
    const m3Month = 13440000;

    console.log(scan);

    //console.log(scan.moonInfo["Balle III - Moon 8"].oreInfo);

    //Convoluted excess looping to reach each ore and it's quantity to attain it's value
    for(var moonInfo in scan) {
        //console.log(key + " : " + scan[key]);
        for(var moon in scan[moonInfo]) {
            totalValue = 0;
            var oreInfoObject = scan[moonInfo][moon];
            for(oreInfo in oreInfoObject) {
                var realOreInfo = oreInfoObject[oreInfo];
                for(oreType in realOreInfo) {
                    refinedValue = 0;
                    var OreID = itemID(oreType);
                    var oreAmount = m3Month*realOreInfo[oreType] / m3PerUnit(oreType);

                    //API call for unrefined ore value based on percentile in The Forge (Region)
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

                            //Round value to 2 decimals
                            unrefinedValue = unrefinedValue.toFixed(2);

                            //Commas added to value
                            unrefinedValue = unrefinedValue.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
                            
                            //Update HTML with unrefined value
                            document.getElementById(oreType + " " + realOreInfo[oreType] + " " + "Raw").innerHTML = unrefinedValue;
                        }
                    }); 
                    var mineralBatch = mineralsPerBatch(oreType);
                    for(mineral in mineralBatch) {
                        var batches = oreAmount/100;
                        var mineralID = itemID(mineral);

                        //Call for individual mineral prices, used to add up for refined value. Based on percentile buy orders in The Forge (Region)
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

                    //Add total value from all ores
                    totalValue += refinedValue;

                    //Round value to 2 decimals
                    refinedValue = refinedValue.toFixed(2);

                    //Commas added to value
                    refinedValue = refinedValue.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
                    
                    //Update HTML with refined value
                    document.getElementById(oreType + " " + realOreInfo[oreType] + " " + "Refined").innerHTML = refinedValue;
                }

            }

            //Round value to 2 decimals
            totalValue = totalValue.toFixed(2);

            //Commas added to value
            totalValue = totalValue.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");

            document.getElementById(moon + " Value").innerHTML = "Total Refined Value: " +  totalValue;
        }
    }
});