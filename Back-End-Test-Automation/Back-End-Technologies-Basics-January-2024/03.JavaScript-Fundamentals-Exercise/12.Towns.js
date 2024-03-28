function solve(inputArr) {
    'use strict';

    function processAndAddObject(objectList, input) {
        let [town, latitude, longitude] = input.split(/\s*\|\s*|\s+/);
        latitude = parseFloat(latitude).toFixed(2);
        longitude = parseFloat(longitude).toFixed(2);

        objectList.Town.push(town);
        objectList.Latitude.push(latitude);
        objectList.Longitude.push(longitude);
    }

    function printResults(objectList) {
        for (const index in objectList.Town) {
            console.log(`{ town: '${objectList.Town[index]}', latitude: '${objectList.Latitude[index]}', longitude: '${objectList.Longitude[index]}' }`);
        }
    }

    let objectList = {
        Town: [],
        Latitude: [],
        Longitude: []
    };

    for (const object of inputArr) {
        processAndAddObject(objectList, object);
    }

    printResults(objectList);
}

solve(['Sofia | 42.696552 | 23.32601', 'Beijing | 39.913818 | 116.363625']);