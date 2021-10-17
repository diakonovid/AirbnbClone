import { Popover } from '@headlessui/react'

function PlaceTypeFilter() {
    return (
    <Popover className="relative border-0">
        <Popover.Button className="focus:outline-none"><p className="filter-button">Type of place</p></Popover.Button>
        <Popover.Panel className="absolute z-10 w-screen max-w-[400px] px-4 mt-3 transform -translate-x-1/2 left-1/2 sm:px-0">
        <div className="overflow-hidden rounded-lg shadow-lg ring-1 ring-black ring-opacity-5">
            <div className="bg-white">
              <div className="ml-5 mt-2">
                <label className="inline-flex items-center space-x-3">
                  <input type="checkbox" className="input-checkbox filter-checkbox text-lg"/>
                  <div>
                    <h4>Entire place</h4>
                    <p className="text-md text-gray-400 font-light">Have a place to yourself</p>
                  </div>
                </label>
              </div>
              <div className="ml-5 mt-2">
                <label className="inline-flex items-center space-x-3">
                  <input type="checkbox" className="input-checkbox filter-checkbox"/>
                  <div>
                    <h4>Private room</h4>
                    <div className="text-md text-gray-400 font-light leading-none">         
                      <p>Have your own room and share some</p>
                      <p>common spaces</p>
                    </div>
                  </div>
                </label>
              </div>
              <div className="ml-5 mt-2">
                <label className="inline-flex items-center space-x-3">
                  <input type="checkbox" className="filter-checkbox"/>
                  <div>
                    <h4>Hotel room</h4>
                    <div className="text-md text-gray-400 font-light leading-none">         
                      <p>Have a private or shared room</p>
                      <p>in a boutique hotel, hostel, and more</p>
                    </div>
                  </div>
                </label>
              </div>
              <div className="ml-5 mt-2">
                <label className="inline-flex items-center space-x-3">
                  <input type="checkbox" className="input-checkbox filter-checkbox"/>
                  <div>
                    <h4>Shared room</h4>
                    <p className="text-md text-gray-400 font-light">Stay in a shared space, like a common room</p>
                  </div>
                </label>
              </div>
              <div className="border-b mt-2"/>
              <div className="px-3 p-2 flex flex-row-reverse">
                <button className="save-button">Save</button>
              </div>
            </div>
        </div>    
        </Popover.Panel>     
      </Popover>
      )
}

export default PlaceTypeFilter
