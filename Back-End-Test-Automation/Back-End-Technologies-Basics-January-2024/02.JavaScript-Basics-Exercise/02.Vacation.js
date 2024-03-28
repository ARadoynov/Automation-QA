function solve(studentsCount, typeOfGroup, dayOfWeek) {
    'use strict';
    let totalPrice = 0;

    if (typeOfGroup === 'Students') {

        if (dayOfWeek === 'Friday') {
            totalPrice = studentsCount * 8.45;

        } else if (dayOfWeek === 'Saturday') {
            totalPrice = studentsCount * 9.80;

        } else if (dayOfWeek === 'Sunday') {
            totalPrice = studentsCount * 10.46;
        }

        if (studentsCount >= 30) {
            totalPrice = totalPrice * 0.85;
        }

    } else if (typeOfGroup === 'Business') {

        if (studentsCount >= 100) {
            studentsCount -= 10;
        }

        if (dayOfWeek === 'Friday') {
            totalPrice = studentsCount * 10.90;

        } else if (dayOfWeek === 'Saturday') {
            totalPrice = studentsCount * 15.60;

        } else if (dayOfWeek === 'Sunday') {
            totalPrice = studentsCount * 16;
        }


    } else if (typeOfGroup === 'Regular') {

        if (dayOfWeek === 'Friday') {
            totalPrice = studentsCount * 15;

        } else if (dayOfWeek === 'Saturday') {
            totalPrice = studentsCount * 20;

        } else if (dayOfWeek === 'Sunday') {
            totalPrice = studentsCount * 22.50;

        }

        if (studentsCount >= 10 && studentsCount <= 20) {
            totalPrice = totalPrice * 0.95;
        }

    }
    console.log(`Total price: ${totalPrice.toFixed(2)}`);
}

solve(40, 'Regular', 'Saturday');