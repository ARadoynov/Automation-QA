import { isSymmetric } from '../src/checkForSymmetry.js';
import { expect } from 'chai';

describe ('isSymmetric', () => {
    it('should return true when empty array is given', () => {
        expect(isSymmetric([])).to.be.true;
    });

    it('should return true when single element array is given', () => {
        expect(isSymmetric([1])).to.be.true;
    });

    it('should return true when multiple element array is given', () => {
        expect(isSymmetric([1, 2, 1])).to.be.true;
    });

    it('should return false when non-array value is given', () => {
        expect(isSymmetric(NaN)).to.be.false;
        expect(isSymmetric(undefined)).to.be.false;
        expect(isSymmetric(null)).to.be.false;
        expect(isSymmetric({})).to.be.false;
        expect(isSymmetric('empty string')).to.be.false;
        expect(isSymmetric(1)).to.be.false;
    });

    it('should return false when a symmetric array with mixed variables is given', () => {
        expect(isSymmetric([1,2,3,'2','1'])).to.be.false;
    });
});