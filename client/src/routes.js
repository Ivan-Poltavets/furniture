import {
    DASHBOARD_ROUTE,
    HOME_ROUTE,
    LOGIN_ROUTE, ORDERS_ROUTE, PRODUCT_ROUTE,
    REGISTRATION_ROUTE,
    SHOP_ROUTE
} from "./utils/consts";
import Shop from "./pages/Shop";
import Auth from "./pages/Auth";
import Home from "./pages/Home";
import ProductPage from "./pages/ProductPage";
import RegisterPage from "./pages/RegisterPage";
import Order from "./pages/Order";
import Dashboard from "./pages/Dashboard";

export const authRoutes = [
    {
        path: ORDERS_ROUTE,
        Component: Order
    }
]

export const ownerRoutes = [
    {
        path: DASHBOARD_ROUTE,
        Component: Dashboard
    }
]

export const publicRoutes = [
    {
        path: LOGIN_ROUTE,
        Component: Auth
    },
    {
        path: REGISTRATION_ROUTE,
        Component: RegisterPage
    },
    {
        path: SHOP_ROUTE,
        Component: Shop
    },
    {
        path: HOME_ROUTE,
        Component: Home
    },
    {
        path: PRODUCT_ROUTE + '/:id',
        Component: ProductPage
    }
]