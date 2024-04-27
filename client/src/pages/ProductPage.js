import { useContext, useEffect, useState } from 'react'
import { PaperClipIcon, StarIcon } from '@heroicons/react/20/solid'
import { RadioGroup } from '@headlessui/react'
import { useNavigate, useParams } from "react-router-dom";
import { fetchOneProduct, removeProduct } from "../http/productAPI";
import { IMAGES_API_ROUTE, SHOP_ROUTE } from "../utils/consts";
import { ChevronLeftIcon, ChevronRightIcon } from '@heroicons/react/20/solid';
import { Context } from "../index";
import { addItemToBasket } from "../http/userAPI";
import UpdateProduct from "../components/modals/UpdateProduct";

const classNames = (...classes) => {
    return classes.filter(Boolean).join(' ');
}

const ProductPage = () => {
    const { user } = useContext(Context);
    const [product, setProduct] = useState({});
    const [loading, setLoading] = useState(true);
    const [tabOpen, setTabOpen] = useState(false);
    const [openUpdateProduct, setOpenUpdateProduct] = useState(false);
    const navigate = useNavigate();

    const { id } = useParams();
    useEffect(() => {
        fetchOneProduct(id).then(data => {
            console.log(data);
            setProduct(data);
        })
            .finally(() => setLoading(false));
    }, []);

    if (loading) {
        return <div>Loading...</div>
    }

    const addToCart = async () => {

        try {
            const request = {
                basketId: user.basket.id,
                productId: product.id,
                quantity: 1
            }
            await addItemToBasket(request);
        }
        catch (error) {
            console.error(error);
        }
    }

    const editProduct = async () => {

    }

    const deleteProduct = async () => {
        console.log(product.id)
        try{
            await removeProduct(product.id);
            navigate(SHOP_ROUTE);
        }
        catch(e)
        {
            console.error(e);
        }
    }

    return (
        <div className="bg-white">
            <div className="pt-6">
                <div className="mx-auto mt-6 max-w-2xl sm:px-6 lg:grid lg:max-w-7xl lg:grid-cols-2 lg:gap-x-8 lg:px-8">
                    <div className="aspect-h-5 aspect-w-5 hidden overflow-hidden rounded-lg lg:block">
                        <img
                            src={IMAGES_API_ROUTE + product.imageUrl}
                            className="h-full w-full object-cover object-center"
                        />
                    </div>

                    <div className="mt-4 lg:row-span-3 lg:mt-0">
                        <div className="lg:col-span-2 lg:border-r lg:border-gray-200 lg:pr-8 mb-10 text-center">
                            <h1 className="text-2xl font-bold tracking-tight text-gray-900 sm:text-3xl">{product.name}</h1>
                        </div>
                        <p>{product.averageRating}</p>
                        <h2 className="sr-only">Product information</h2>
                        <p className="text-3xl text-center tracking-tight text-gray-900">{product.price} грн</p>

                        {user.isAdmin()
                            ?
                            <div> 
                                <button
                                onClick={() => setOpenUpdateProduct(true)}
                                className="mt-10 flex w-full items-center justify-center rounded-md border border-transparent bg-indigo-600 px-8 py-3 text-base font-medium text-white hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-indigo-500 focus:ring-offset-2"
                                >
                                    Edit
                                </button>
                                <button
                                onClick={deleteProduct}
                                className="mt-2 flex w-full items-center justify-center rounded-md border border-transparent bg-red-600 px-8 py-3 text-base font-medium text-white hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-indigo-500 focus:ring-offset-2"
                                >
                                    Delete
                                </button>
                            </div>
                            : <button
                                onClick={addToCart}
                                className="mt-10 flex w-full items-center justify-center rounded-md border border-transparent bg-indigo-600 px-8 py-3 text-base font-medium text-white hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-indigo-500 focus:ring-offset-2"
                            >
                                Add to cart
                            </button>
                        }

                    </div>
                </div>
            </div>

            <div className="mx-auto mt-20 max-w-3xl sm:px-6">
                <div className="flex justify-content-center align-items-center mb-10">
                    <div>
                        <button
                            className="block items-center px-4 py-2 text-sm font-semibold text-gray-900 ring-1 ring-inset ring-gray-300 hover:bg-gray-50 focus:z-20 focus:outline-offset-0 md:inline-flex"
                            onClick={() => setTabOpen(false)}
                        >
                            Features
                        </button>
                    </div>

                    <div>
                        <button
                            className="block items-center px-4 py-2 text-sm font-semibold text-gray-900 ring-1 ring-inset ring-gray-300 hover:bg-gray-50 focus:z-20 focus:outline-offset-0 md:inline-flex"
                            onClick={() => setTabOpen(true)}
                        >
                            Reviews
                        </button>
                    </div>
                </div>
                {tabOpen
                    ?
                    <div>
                        {product.reviews.map((review) => (
                            <div>
                                <p>{review.comment}</p>
                            </div>
                        ))}
                    </div>
                    :
                    <div>
                        <div className="px-4 sm:px-0">
                            <h3 className="text-base font-semibold leading-7 text-gray-900">Features</h3>
                            <p className="mt-1 max-w-2xl text-sm leading-6 text-gray-500">Feature details of product</p>
                        </div>
                        <div className="mt-6 border-t border-gray-100">
                            <dl className="divide-y divide-gray-100">
                                <div className="px-4 py-6 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-0">
                                    <dt className="text-sm font-medium leading-6 text-gray-900">Full name</dt>
                                    <dd className="mt-1 text-sm leading-6 text-gray-700 sm:col-span-2 sm:mt-0">Margot
                                        Foster
                                    </dd>
                                </div>
                                <div className="px-4 py-6 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-0">
                                    <dt className="text-sm font-medium leading-6 text-gray-900">Application for</dt>
                                    <dd className="mt-1 text-sm leading-6 text-gray-700 sm:col-span-2 sm:mt-0">Backend
                                        Developer
                                    </dd>
                                </div>
                                <div className="px-4 py-6 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-0">
                                    <dt className="text-sm font-medium leading-6 text-gray-900">Email address</dt>
                                    <dd className="mt-1 text-sm leading-6 text-gray-700 sm:col-span-2 sm:mt-0">margotfoster@example.com</dd>
                                </div>
                                <div className="px-4 py-6 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-0">
                                    <dt className="text-sm font-medium leading-6 text-gray-900">Salary expectation
                                    </dt>
                                    <dd className="mt-1 text-sm leading-6 text-gray-700 sm:col-span-2 sm:mt-0">$120,000</dd>
                                </div>
                            </dl>
                        </div>
                    </div>
                }

            </div>

            <UpdateProduct open={openUpdateProduct} setOpen={setOpenUpdateProduct} product={product}/>
        </div>
    )
};

export default ProductPage;