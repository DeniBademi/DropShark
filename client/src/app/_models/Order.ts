export class Order{
    constructor(
        public sellerId: number,
        public buyerId: number,
        public productId: number,
        public addressLine: string,
        public zipCode: number
    ) {}
}