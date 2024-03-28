import { sum } from '../src/sumNumbers.js';
import { expect } from 'chai';

describe('Sum numbers', () => {
    it('sums single number', () => {
        expect(sum([1])).to.equal(1);
    });

    it('sums multiple numbers', () => {
        expect(sum([1,1])).to.equal(2);
    });

    it('sums different numbers', () => {
        expect(sum([2,3,4])).to.equal(9);
    });
});
