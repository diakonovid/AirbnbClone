import { useRouter } from "next/dist/client/router"
import Footer from "../components/Footer"
import Header from "../components/Header"
import { format } from "date-fns";
import InfoCard from "../components/InfoCard";
import Map from "../components/Map";
import PriceFilter from "../components/filter/PriceFilter";
import CancelationFilter from "../components/filter/CancellationFilter";
import InstantBookFilter from "../components/filter/InstantBookFilter";
import PlaceTypeFilter from "../components/filter/PlaceTypeFilter";
import { API_URL } from "../utils/consts";

function Search({ searchResult }) {

    const router = useRouter();

    const {location, startDate, endDate, noOfGuests} = router.query;

    const formattedStartDate = format(new Date(startDate), "dd MMMM yy");
    const formattedEndDate = format(new Date(endDate), "dd MMMM yy");
    const range = `${formattedStartDate} - ${formattedEndDate}`;

    return (
        <div>
            <Header placeholder={`${location} | ${range} | ${noOfGuests} guests`}/>

            <main className="flex">
                <section className="flex-grow pt-14 px-6 xl:h-[91vh] xl:overflow-y-auto">
                    <p className="text-xs">300+ stays - {range} - for {noOfGuests} guests</p>

                    <h1 className="text-3xl font-semibold mt-2 mb-6">Stays in {location}</h1>

                    <div className="hidden md:inline-flex mb-5 space-x-3
                        text-gray-800 whitespace-nowrap select-none">
                        <CancelationFilter/>
                        <PlaceTypeFilter/>
                        <PriceFilter/>
                        <InstantBookFilter/>
                        <p className="filter-button">More filters</p>
                    </div>

                    <div className="flex flex-col">
                        {searchResult.map(({img, location, title, description, star, price, total}) => (
                            <InfoCard 
                                key={img}
                                img={img}
                                location={location}
                                title={title}
                                description={description}
                                star={star}
                                price={price}
                                total={total}
                            />
                        ))}
                    </div>
                </section>

                <section className="hidden xl:inline-flex xl:min-w-[700px]">
                    <Map searchResult={searchResult}/>
                </section>
            </main>
            <Footer/>
        </div>
    )
}

export default Search

export async function getServerSideProps(context) {
    let url = new URL(API_URL)
    url.search = new URLSearchParams({
        ...context.query
    })
    const searchResult = await fetch(url)
    .then(
        (res) => res.json()
    );
    return {
        props:{
            searchResult
        }
    }
}
