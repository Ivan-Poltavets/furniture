import React, { Fragment, useContext, useEffect, useRef, useState } from 'react';
import { Dialog, Transition, Listbox } from "@headlessui/react";
import { Context } from "../../index";
import { CheckIcon, ChevronUpDownIcon } from '@heroicons/react/20/solid'
import { createProduct } from '../../http/productAPI';

function classNames(...classes) {
    return classes.filter(Boolean).join(' ')
}

const CreateProduct = ({ open, setOpen }) => {
    const { product } = useContext(Context);
    const cancelButtonRef = useRef(null);
    const [name, setName] = useState("");
    const [discount, setDiscount] = useState("");
    const [price, setPrice] = useState("");
    const [selectedCategory, setSelectedCategory] = useState(product.categories[0]);

    const [loading, setLoading] = useState(true);

    useEffect(() => {
        console.log(selectedCategory);
        if (selectedCategory !== null || selectedCategory !== undefined) {
            setLoading(false);
        }
        else{
            setSelectedCategory(product.categories[0]);
        }
    }, [selectedCategory])

    if (loading) {
        return <div>Loading...</div>
    }


    const addProduct = async () => {
        const json = {
            name: name,
            discountInPercent: discount,
            price: price,
            categoryId: selectedCategory.id,
        }

        try{
            await createProduct(json);
        }
        catch(e){
            console.error(e);
        }
    }

    return (
        <Transition.Root show={open} as={Fragment}>
            <Dialog as="div" className="relative z-10" initialFocus={cancelButtonRef} onClose={setOpen}>
                <Transition.Child
                    as={Fragment}
                    enter="ease-out duration-300"
                    enterFrom="opacity-0"
                    enterTo="opacity-100"
                    leave="ease-in duration-200"
                    leaveFrom="opacity-100"
                    leaveTo="opacity-0"
                >
                    <div className="fixed inset-0 bg-gray-500 bg-opacity-75 transition-opacity" />
                </Transition.Child>

                <div className="fixed inset-0 z-10 w-screen overflow-y-auto">
                    <div className="flex min-h-full items-end justify-center p-4 text-center sm:items-center sm:p-0">
                        <Transition.Child
                            as={Fragment}
                            enter="ease-out duration-300"
                            enterFrom="opacity-0 translate-y-4 sm:translate-y-0 sm:scale-95"
                            enterTo="opacity-100 translate-y-0 sm:scale-100"
                            leave="ease-in duration-200"
                            leaveFrom="opacity-100 translate-y-0 sm:scale-100"
                            leaveTo="opacity-0 translate-y-4 sm:translate-y-0 sm:scale-95"
                        >
                            <Dialog.Panel className="relative transform overflow-hidden rounded-lg bg-white text-left shadow-xl transition-all sm:my-8 sm:w-full sm:max-w-lg">
                                <div className="bg-white px-4 pb-4 pt-5 sm:p-6 sm:pb-4">
                                    <div className="sm:flex sm:items-start w-full">
                                        <div className="mt-3 text-center sm:ml-4 sm:mt-0 sm:text-left">
                                            <Dialog.Title as="h3" className="text-2xl font-semibold leading-8 text-gray-900">
                                                Create product
                                            </Dialog.Title>
                                            <div className="mt-6 ml-40 mr-40">
                                                <div>
                                                    <label htmlFor="categoryName"
                                                        className="block text-sm font-medium leading-6 text-gray-900">
                                                        Name
                                                    </label>
                                                    <div className="w-full">
                                                        <input
                                                            id="categoryName"
                                                            name="categoryName"
                                                            autoComplete="email"
                                                            required
                                                            className="block w-full rounded-md border-0 py-1.5 text-gray-900 shadow-sm ring-1 ring-inset ring-gray-300 placeholder:text-gray-400 focus:ring-2 focus:ring-inset focus:ring-indigo-600 sm:text-sm sm:leading-6"
                                                            onChange={(e) => setName(e.target.value)}
                                                        />
                                                    </div>
                                                </div>
                                                <div>
                                                    <label htmlFor="categoryName"
                                                        className="block text-sm font-medium leading-6 text-gray-900">
                                                        Category
                                                    </label>
                                                    <div className="w-full">
                                                        <Listbox value={selectedCategory} onChange={selectedCategory}>
                                                            {({ open }) => (
                                                                <>
                                                                    <Listbox.Label className="block text-sm font-medium leading-6 text-gray-900">Assigned to</Listbox.Label>
                                                                    <div className="relative mt-2">
                                                                        <Listbox.Button className="relative w-full cursor-default rounded-md bg-white py-1.5 pl-3 pr-10 text-left text-gray-900 shadow-sm ring-1 ring-inset ring-gray-300 focus:outline-none focus:ring-2 focus:ring-indigo-500 sm:text-sm sm:leading-6">
                                                                            <span className="flex items-center">
                                                                                <span className="ml-3 block truncate">{selectedCategory.name}</span>
                                                                            </span>
                                                                            <span className="pointer-events-none absolute inset-y-0 right-0 ml-3 flex items-center pr-2">
                                                                                <ChevronUpDownIcon className="h-5 w-5 text-gray-400" aria-hidden="true" />
                                                                            </span>
                                                                        </Listbox.Button>

                                                                        <Transition
                                                                            show={open}
                                                                            as={Fragment}
                                                                            leave="transition ease-in duration-100"
                                                                            leaveFrom="opacity-100"
                                                                            leaveTo="opacity-0"
                                                                        >
                                                                            <Listbox.Options className="absolute z-10 mt-1 max-h-56 w-full overflow-auto rounded-md bg-white py-1 text-base shadow-lg ring-1 ring-black ring-opacity-5 focus:outline-none sm:text-sm">
                                                                                {product.categories.map((item) => (
                                                                                    <Listbox.Option
                                                                                        key={item.id}
                                                                                        className={({ active }) =>
                                                                                            classNames(
                                                                                                active ? 'bg-indigo-600 text-white' : 'text-gray-900',
                                                                                                'relative cursor-default select-none py-2 pl-3 pr-9'
                                                                                            )
                                                                                        }
                                                                                        value={item}
                                                                                    >
                                                                                        {({ selected, active }) => (
                                                                                            <>
                                                                                                <div className="flex items-center">
                                                                                                    <span
                                                                                                        className={classNames(selected ? 'font-semibold' : 'font-normal', 'ml-3 block truncate')}
                                                                                                    >
                                                                                                        {item.name}
                                                                                                    </span>
                                                                                                </div>

                                                                                                {selected ? (
                                                                                                    <span
                                                                                                        className={classNames(
                                                                                                            active ? 'text-white' : 'text-indigo-600',
                                                                                                            'absolute inset-y-0 right-0 flex items-center pr-4'
                                                                                                        )}
                                                                                                    >
                                                                                                        <CheckIcon className="h-5 w-5" aria-hidden="true" />
                                                                                                    </span>
                                                                                                ) : null}
                                                                                            </>
                                                                                        )}
                                                                                    </Listbox.Option>
                                                                                ))}
                                                                            </Listbox.Options>
                                                                        </Transition>
                                                                    </div>
                                                                </>
                                                            )}
                                                        </Listbox>
                                                    </div>
                                                </div>
                                                <div>
                                                    <label htmlFor="discount"
                                                        className="block text-sm font-medium leading-6 text-gray-900">
                                                        Discount
                                                    </label>
                                                    <div className="w-full">
                                                        <input
                                                            id="discount"
                                                            name="discount"
                                                            required
                                                            className="block w-full rounded-md border-0 py-1.5 text-gray-900 shadow-sm ring-1 ring-inset ring-gray-300 placeholder:text-gray-400 focus:ring-2 focus:ring-inset focus:ring-indigo-600 sm:text-sm sm:leading-6"
                                                            onChange={(e) => setDiscount(e.target.value)}
                                                        />
                                                    </div>
                                                </div>
                                                <div>
                                                    <label htmlFor="price"
                                                        className="block text-sm font-medium leading-6 text-gray-900">
                                                        Price
                                                    </label>
                                                    <div className="w-full">
                                                        <input
                                                            id="price"
                                                            name="price"
                                                            autoComplete="email"
                                                            required
                                                            className="block w-full rounded-md border-0 py-1.5 text-gray-900 shadow-sm ring-1 ring-inset ring-gray-300 placeholder:text-gray-400 focus:ring-2 focus:ring-inset focus:ring-indigo-600 sm:text-sm sm:leading-6"
                                                            onChange={(e) => setPrice(e.target.value)}
                                                        />
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div className="bg-gray-50 px-4 py-3 sm:flex sm:flex-row-reverse sm:px-6">
                                    <button
                                        type="button"
                                        className="inline-flex w-full justify-center rounded-md bg-indigo-600 px-3 py-2 text-sm font-semibold text-white shadow-sm hover:bg-red-500 sm:ml-3 sm:w-auto"
                                        onClick={addProduct}
                                    >
                                        Add
                                    </button>
                                    <button
                                        type="button"
                                        className="mt-3 inline-flex w-full justify-center rounded-md bg-white px-3 py-2 text-sm font-semibold text-gray-900 shadow-sm ring-1 ring-inset ring-gray-300 hover:bg-gray-50 sm:mt-0 sm:w-auto"
                                        onClick={() => setOpen(false)}
                                        ref={cancelButtonRef}
                                    >
                                        Cancel
                                    </button>
                                </div>
                            </Dialog.Panel>
                        </Transition.Child>
                    </div>
                </div>
            </Dialog>
        </Transition.Root>
    );
};

export default CreateProduct;