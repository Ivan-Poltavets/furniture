import {makeAutoObservable} from "mobx";

export default class UserStore {
    constructor() {
        this._isAuth = false;
        this._user = {};
        this._basket = {};
        makeAutoObservable(this);
    }

    setIsAuth(bool){
        this._isAuth = bool;
    }

    setUser(user){
        this._user = user;
    }

    setBasket(basket) {
        this._basket = basket;
    }

    isAdmin() {
        return this._user !== null && this._user.role === 1;
    }

    isOwner(){
        return this._user !== null && this._user.role === 2;
    }

    get isAuth(){
        return this._isAuth;
    }

    get user(){
        return this._user;
    }

    get basket(){
        return this._basket;
    }
}