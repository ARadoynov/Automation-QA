function dvd_collection(inputArr) {

    let n = parseInt(inputArr[0]);
    let moviesList = inputArr.slice(1, n + 1);

    for (let i = n + 1; i < inputArr.length; i++) {
        let command = inputArr[i].split(" ");
        
        
        switch (command[0]) {
            case "Watch":
                if (moviesList.length > 0) {
                    console.log(`${moviesList.shift()} DVD watched!`);
                }
                break;
            case "Buy":
                moviesList.push(command.slice(1).join(" "));
                break;
            case "Swap":
                let startIndex = parseInt(command[1]);
                let endIndex = parseInt(command[2]);
                if (startIndex >= 0 && startIndex < moviesList.length &&
                    endIndex >= 0 && endIndex < moviesList.length) {
                    let temp = moviesList[startIndex];
                    moviesList[startIndex] = moviesList[endIndex];
                    moviesList[endIndex] = temp;
                    console.log("Swapped!");
                }
                break;
            case "Done":
                if (moviesList.length > 0) {
                    console.log("DVDs left: " + moviesList.join(", "));
                } else {
                    console.log("The collection is empty");
                }
                return;
        }
    }
}

dvd_collection (['5', 'The Lion King', 'Frozen', 'Moana', 'Toy Story', 'Shrek', 'Buy Coco', 'Swap 2 4', 'Done']);