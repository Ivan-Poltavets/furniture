import {observer} from "mobx-react-lite";
import {useContext, useEffect, useState} from "react";
import {Context} from "../index";
import {fetchCategories, fetchProducts} from "../http/productAPI";
import ProductList from "../components/ProductList";
import TypeBar from "../components/TypeBar";

const Shop = observer(() => {
    const {product} = useContext(Context);
    const [loading, setLoading] = useState(true);

    useEffect(() => {
        fetchCategories().then(data => {
            product.setCategories(data);
        });
        fetchProducts().then(data => {
            console.log(data);
            product.setProducts(data);
        })
        .finally(() => setLoading(false));
    }, [product.page, product.selectedCategory])


    return (
        <div>
            <TypeBar/>
        </div>
    );
});

export default Shop;