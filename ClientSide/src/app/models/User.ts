import { IUser } from "./IUser";

export class User implements IUser{
    constructor(
    public id: any = null,
    public name: any = null
    ){}
}