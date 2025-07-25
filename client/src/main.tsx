import { StrictMode } from "react";
import { createRoot } from "react-dom/client";
import "./app/layout/styles.css";
import { QueryClient, QueryClientProvider } from "@tanstack/react-query";
import { ReactQueryDevtools } from "@tanstack/react-query-devtools";
import { RouterProvider } from "react-router";
import { router } from "./app/router/Routes";
import { store, StoreContext } from "./lib/stores/store";
import "react-toastify/dist/ReactToastify.css";
import { ToastContainer } from "react-toastify";
import { LocalizationProvider } from "@mui/x-date-pickers";
import { AdapterDateFns } from "@mui/x-date-pickers/AdapterDateFns";

const queryClient = new QueryClient();

createRoot(document.getElementById("root")!).render(
  <StrictMode>
    <LocalizationProvider dateAdapter={AdapterDateFns}>
      <StoreContext.Provider value={store}>
        <QueryClientProvider client={queryClient}>
          <ReactQueryDevtools />
          <ToastContainer
            position="bottom-right"
            hideProgressBar
            theme="colored"
          />
          <RouterProvider router={router} />
        </QueryClientProvider>
      </StoreContext.Provider>
    </LocalizationProvider>
  </StrictMode>
);
